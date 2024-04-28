using Antlr4.Runtime.Dfa;
using Antlr4.Runtime.Misc;
using Antlr4.StringTemplate.Misc;
using Maps.Persistence;
using NetTopologySuite.Geometries;

namespace Maps;

public class BasicVisitor : GetUMPStxBaseVisitor<object>
{
    public static int SectionCount { get; set; } = 0;
    public static int POICount { get; set; } = 0;
    public static int PolylineCount { get; set; } = 0;
    public static int PolyGonCount { get; set; } = 0;
    private PMF_Map_Section? currentSection;
    private PMF_Map_Polyline? currentPolylineSection;
    private PMF_Map_Polygon? currentPolygonSection;
    private PMF_Map_POI? currentPOISection;
    private PMF_Map currentMap;

    public BasicVisitor()
    {
        
    }

    public override object VisitPolygon_section([NotNull] GetUMPStx.Polygon_sectionContext context)
    {

        PolyGonCount++;
        currentPolygonSection = new PMF_Map_Polygon() { PMF_Map = currentMap };
        
        var res = base.VisitPolygon_section(context);
        if (currentPolygonSection is not null)
        {
            currentMap?.Polygons.Add(currentPolygonSection);
            if (currentSection is not null)
            {

                currentSection.Polygons.Add(currentPolygonSection);
                currentSection.Type = "POLYGON";
            }
        }

        
        currentPolygonSection = null;
        return res;
    }

    public override object VisitPolyline_section([NotNull] GetUMPStx.Polyline_sectionContext context)
    {
        PolylineCount++;
        currentPolylineSection = new PMF_Map_Polyline() { PMF_Map = currentMap };
        var res = base.VisitPolyline_section(context);
        if (currentPolylineSection is not null)
        {
            currentMap?.Polylines.Add(currentPolylineSection);
            if(currentSection is not null)
            {
                currentSection.Polylines.Add(currentPolylineSection);
                currentSection.Type = "POLYLINE";
            }
        }
        currentPolylineSection = null;
        return res;
    }

    public override object VisitPoi_section([NotNull] GetUMPStx.Poi_sectionContext context)
    {
        POICount++;
        currentPOISection = new PMF_Map_POI() { PMF_Map = currentMap };
        var res = base.VisitPoi_section(context);
        if (currentPOISection is not null)
        {
            currentMap?.POIs.Add(currentPOISection);
            if (currentSection is not null)
            {
                currentSection.POIs.Add(currentPOISection);
                currentSection.Type = "POI";
            }
        }
        currentPOISection = null;
        return res;
    }

    public override object VisitFile([NotNull] GetUMPStx.FileContext context)
    {
        if(currentMap is null) currentMap = new PMF_Map() { POIs = [], Polygons = [], Polylines = [], Sections = [] };
        var result = base.VisitFile(context);
        Console.WriteLine($"Section count: {SectionCount}");
        Console.WriteLine($"POI count: {POICount}");
        Console.WriteLine($"Polyline count: {PolylineCount}");
        Console.WriteLine($"Polygon count: {PolyGonCount}");
        return result;

    }
    public override object VisitSection([NotNull] GetUMPStx.SectionContext context)
    {
        //Console.WriteLine(context.GetText());
        SectionCount++;
        currentSection = new PMF_Map_Section() 
        { 
            FileSectionNumber = SectionCount, 
            PMF_Map = currentMap, 
            Type = context.default_section()?.GetText()??"", 
            Name=context.default_section()?.SECTstart()?.GetText()??""
        };
        var res =base.VisitSection(context);
        if(currentSection is not null)
        {
            currentMap?.Sections.Add(currentSection);
        }
        currentSection = null;
        return res;
    }

    public override object VisitIdxEq([NotNull] GetUMPStx.IdxEqContext context)
    {
        
        var id = context.idx.GetText();
        var idnum = int.Parse(context.idx.NUM().GetText());
        var val = context.val?.Text ?? "";

        PMF_Map_Attribute attr = new PMF_Map_Attribute() { Name = $"{id}{idnum}", Key = id, KeyIdx=idnum, Value = val };
        if(currentMap is not null)
        {
            attr.PMF_Map = currentMap;

            if (currentSection is not null)
            {
                currentSection.Attributes.Add(attr);

            }
        }
        



        return base.VisitIdxEq(context);
    }

    public override object VisitSimpleEq([NotNull] GetUMPStx.SimpleEqContext context)
    {
        var key = context.key.Text;
        var val = context.val?.Text ?? "";

        PMF_Map_Attribute attr = new PMF_Map_Attribute() { Name = key, Key = key, Value = val };
        if (currentMap is not null)
        {
            attr.PMF_Map = currentMap;

            if (currentSection is not null)
            {
                currentSection.Attributes.Add(attr);

            }
        }

        return base.VisitSimpleEq(context);
    }

    public override object VisitSimpleEqPoints([NotNull] GetUMPStx.SimpleEqPointsContext context)
    {
        
        var key = context.key.Text;
        var pointsstr = context.pointsval.Text;
        pointsstr = pointsstr.Substring(1, pointsstr.Length - 2);
        List<NetTopologySuite.Geometries.Point> points = [];
        List<NetTopologySuite.Geometries.Coordinate> coords = [];
        foreach (var item in pointsstr.Split("),("))
        {

            var latitude = item.Split(",")[0];
            var longitude = item.Split(",")[1];
            //Console.WriteLine($"Latitude: {latitude}, Longitude {longitude}");

            points.Add(new Point(
                 double.Parse(
                     longitude,
                     System.Globalization.NumberStyles.AllowDecimalPoint,
                     System.Globalization.NumberFormatInfo.InvariantInfo),
                 double.Parse(latitude,
                     System.Globalization.NumberStyles.AllowDecimalPoint,
                     System.Globalization.NumberFormatInfo.InvariantInfo)
                 ));
        }
        coords = points.Select(p => p.Coordinate).ToList();
        if (points is null || points.Count == 0) return base.VisitSimpleEqPoints(context);
        if (currentPOISection is not null)
        {
            currentPOISection.Name = key;
            currentPOISection.Key = key;
            currentPOISection.Point = points[0];
        }
        else if (currentPolygonSection is not null)
        {
            currentPolygonSection.Name = key;
            currentPolygonSection.Key = key;
            currentPolygonSection.Polygon = new Polygon(new LinearRing(coords.ToArray()));
                //currentPolygonSection.Points.Add(new Coordinate(double.Parse(latitude), double.Parse(longitude)));
            }
        else if (currentPolylineSection is not null)
        {
            currentPolylineSection.Name = key;
            currentPolylineSection.Key = key;
            currentPolylineSection.LineString = new LineString(coords.ToArray());
        }
        return base.VisitSimpleEqPoints(context);
    }

    public override object VisitIdxEqPoints([NotNull] GetUMPStx.IdxEqPointsContext context)
    {

        var key = context.idx.ID().GetText();
        var keyIdx = int.Parse(context.idx.NUM().GetText());
        var pointsstr = context.pointsval.Text;
        pointsstr = pointsstr.Substring(1, pointsstr.Length - 2);
        List<NetTopologySuite.Geometries.Point> points = [];
        List<NetTopologySuite.Geometries.Coordinate> coords = [];
        foreach (var item in pointsstr.Split("),("))
        {

            var latitude = item.Split(",")[0];
            var longitude = item.Split(",")[1];
            //Console.WriteLine($"Latitude: {latitude}, Longitude {longitude}");

            points.Add(new Point(
                double.Parse(
                    longitude,
                    System.Globalization.NumberStyles.AllowDecimalPoint,
                    System.Globalization.NumberFormatInfo.InvariantInfo), 
                double.Parse(latitude, 
                    System.Globalization.NumberStyles.AllowDecimalPoint, 
                    System.Globalization.NumberFormatInfo.InvariantInfo)
                ));
        }
        coords = points.Select(p => p.Coordinate).ToList();
        if (points is null || points.Count == 0) return base.VisitIdxEqPoints(context);
        if (currentPOISection is not null)
        {
            currentPOISection.Name = $"{key}{keyIdx}";
            currentPOISection.Key = key;
            currentPOISection.KeyIdx = keyIdx;
            currentPOISection.Point = points[0];
        }
        else if (currentPolygonSection is not null)
        {
            currentPolygonSection.Name = $"{key}{keyIdx}";
            currentPolygonSection.Key = key;
            currentPolygonSection.KeyIdx = keyIdx;
            coords.Add(coords[0]);
            currentPolygonSection.Polygon = new Polygon(new LinearRing(coords.ToArray()));
            //currentPolygonSection.Points.Add(new Coordinate(double.Parse(latitude), double.Parse(longitude)));
        }
        else if (currentPolylineSection is not null)
        {
            currentPolylineSection.Name = $"{key}{keyIdx}";
            currentPolylineSection.Key = key;
            currentPolylineSection.KeyIdx = keyIdx;
            currentPolylineSection.LineString = new LineString(coords.ToArray());
        }


       /* //var tmp = context.pointsva.Type.ToString();
        var pointsstr = context.pointsval.Text;
        pointsstr = pointsstr.Substring(1, pointsstr.Length - 2);
        foreach(var item in pointsstr.Split("),("))
        {

            var latitude = item.Split(",")[0];
            var longitude = item.Split(",")[1];
            Console.WriteLine($"Latitude: {latitude}, Longitude {longitude}");
        }

        foreach (var pt in context.GetTokens(GetUMPStx.POINTS))
        {
            Console.WriteLine(pt.GetText());
        }*/
        return base.VisitIdxEqPoints(context);
    }

    public override object VisitSimpleEqPoint([NotNull] GetUMPStx.SimpleEqPointContext context)
    {
        var key = context.key.Text;
        var pointstr = context.pointval.Text;
        pointstr = pointstr.Substring(1, pointstr.Length - 2);
        List<NetTopologySuite.Geometries.Point> points = [];
        List<NetTopologySuite.Geometries.Coordinate> coords = [];
        foreach (var item in pointstr.Split("),("))
        {

            var latitude = item.Split(",")[0];
            var longitude = item.Split(",")[1];
            //Console.WriteLine($"Latitude: {latitude}, Longitude {longitude}");

            points.Add(new Point(
                 double.Parse(
                     longitude,
                     System.Globalization.NumberStyles.AllowDecimalPoint,
                     System.Globalization.NumberFormatInfo.InvariantInfo),
                 double.Parse(latitude,
                     System.Globalization.NumberStyles.AllowDecimalPoint,
                     System.Globalization.NumberFormatInfo.InvariantInfo)
                 ));
        }
        coords = points.Select(p => p.Coordinate).ToList();
        if (points is null || points.Count == 0) return base.VisitSimpleEqPoint(context);
        if (currentPOISection is not null)
        {
            currentPOISection.Name = key;
            currentPOISection.Key = key;
            currentPOISection.Point = points[0];
        }
        else
        {
            PMF_Map_Attribute attr = new PMF_Map_Attribute() { Name = key, Key = key, Value = pointstr };
            if (currentMap is not null)
            {
                attr.PMF_Map = currentMap;

                if (currentSection is not null)
                {
                    currentSection.Attributes.Add(attr);

                }
            }

        }




        return base.VisitSimpleEqPoint(context);
    }

    public override object VisitIdxEqPoint([NotNull] GetUMPStx.IdxEqPointContext context)
    {
        var key = context.idx.ID().GetText();
        var keyIdx = int.Parse(context.idx.NUM().GetText());
        var pointstr = context.pointval.Text;
        pointstr = pointstr.Substring(1, pointstr.Length - 2);
        List<NetTopologySuite.Geometries.Point> points = [];
        List<NetTopologySuite.Geometries.Coordinate> coords = [];

        var latitude = pointstr.Split(",")[0];
        var longitude = pointstr.Split(",")[1];
        //Console.WriteLine($"Latitude: {latitude}, Longitude {longitude}");

        points.Add(new Point(
            double.Parse(
                longitude,
                System.Globalization.NumberStyles.AllowDecimalPoint,
                System.Globalization.NumberFormatInfo.InvariantInfo),
            double.Parse(latitude,
                System.Globalization.NumberStyles.AllowDecimalPoint,
                System.Globalization.NumberFormatInfo.InvariantInfo)
            ));
        coords = points.Select(p => p.Coordinate).ToList();
        if (points is null || points.Count == 0) return base.VisitIdxEqPoint(context);
        if (currentPOISection is not null)
        {
            currentPOISection.Name = $"{key}{keyIdx}";
            currentPOISection.Key = key;
            currentPOISection.KeyIdx = keyIdx;
            currentPOISection.Point = points[0];
        }
        else
        {
            PMF_Map_Attribute attr = new PMF_Map_Attribute() { Name = $"{key}{keyIdx}", Key = key,KeyIdx=keyIdx, Value = pointstr };
            if (currentMap is not null)
            {
                attr.PMF_Map = currentMap;

                if (currentSection is not null)
                {
                    currentSection.Attributes.Add(attr);

                }
            }

        }
        return base.VisitIdxEqPoint(context);
    }
}