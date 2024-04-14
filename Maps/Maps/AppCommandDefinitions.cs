using Maps.Persistence;
using NetTopologySuite.Geometries;

namespace Maps;
public static class AppCommandDefinitions
{
    public static void TestDb(MyDbContext context)
    {
        var db = context.Database;
        var v = context.Database.CanConnect();

        if(v)
        {
            context.MapPolylines.Select(p => p.LineString.AsText()).ToList().ForEach(Console.WriteLine);

            var map = new PMF_Map
            {
                Bytes = new byte[] { 1, 2, 3, 4 },
                Description = "Test",
                FileName = "Test"
            };

            context.Maps.Add(map);

            context.SaveChanges();

            context.MapPOIs.Add(new PMF_Map_POI
            {
                Name = "Test",
                Point = new Point(1, 1),
                PMF_Map = map
            });

            context.SaveChanges();

            context.MapPolylines.Add(new PMF_Map_Polyline
            {
                Name = "Test",
                LineString = new LineString(new Coordinate[] { new Coordinate(1, 1), new Coordinate(2, 2) }),
                PMF_Map = map
            });

            context.SaveChanges();

            context.MapPolygons.Add(new PMF_Map_Polygon
            {
                Name = "Test",
                Polygon = new Polygon(new LinearRing(new Coordinate[] { new Coordinate(1, 1), new Coordinate(2, 2), new Coordinate(3, 3), new Coordinate(1, 1) })),
                PMF_Map = map
            });

            context.SaveChanges();
        }

        Console.WriteLine($"TestDb {db}");
    }
}
