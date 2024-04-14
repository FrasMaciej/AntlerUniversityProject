using Antlr4.Runtime.Misc;

namespace Maps
{
    public class BasicVisitor : GetUMPStxBaseVisitor<object>
    {
        public static int SectionCount { get; set; } = 0;
        public static int POICount { get; set; } = 0;
        public static int PolylineCount { get; set; } = 0;
        public static int PolyGonCount { get; set; } = 0;
        public BasicVisitor()
        {
            
        }

        public override object VisitPolygon_section([NotNull] GetUMPStx.Polygon_sectionContext context)
        {
            PolyGonCount++;
            return base.VisitPolygon_section(context);
        }

        public override object VisitPolyline_section([NotNull] GetUMPStx.Polyline_sectionContext context)
        {
            PolylineCount++;
            return base.VisitPolyline_section(context);
        }

        public override object VisitPoi_section([NotNull] GetUMPStx.Poi_sectionContext context)
        {
            POICount++;
            return base.VisitPoi_section(context);
        }

        public override object VisitFile([NotNull] GetUMPStx.FileContext context)
        {
            var result = base.VisitFile(context);
            Console.WriteLine($"Section count: {SectionCount}");
            Console.WriteLine($"POI count: {POICount}");
            Console.WriteLine($"Polyline count: {PolylineCount}");
            Console.WriteLine($"Polygon count: {PolyGonCount}");
            return result;

        }

        public override object VisitIdxEq([NotNull] GetUMPStx.IdxEqContext context)
        {
            var a = context.V();
            var id = context.idx.GetText();
            var idnum = context.idx.NUM();
            var b = context.val.Text;
            return base.VisitIdxEq(context);
        }

        public override object VisitSimpleEq([NotNull] GetUMPStx.SimpleEqContext context)
        {
            return base.VisitSimpleEq(context);
        }

        public override object VisitSection([NotNull] GetUMPStx.SectionContext context)
        {
            //Console.WriteLine(context.GetText());
            SectionCount++;
            return base.VisitSection(context);
        }

    }
}