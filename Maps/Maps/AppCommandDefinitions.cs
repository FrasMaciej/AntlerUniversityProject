using Antlr4.Runtime;
using Cocona;
using Maps.Persistence;
using Microsoft.Extensions.Logging;
using NetTopologySuite.Geometries;
using System.Text;

namespace Maps;
public class AppCommandDefinitions
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

    public static void TestStringTemplate([FromService]ILogger<AppCommandDefinitions> logger)
    {
        var st = new Antlr4.StringTemplate.Template("Hello, <name>!");
        st.Add("name", "World from StringTemplate");
        logger.LogInformation(st.Render());
        //Console.WriteLine(st.Render());
    }

    public static void TestParseFile()
    {
        string input;

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        //input = File.ReadAllText("wynik.mp",Encoding.GetEncoding("ISO-8859-1"));
        input = File.ReadAllText("wynik.mp", Encoding.GetEncoding(1250));

        var lexer = new GetUMPLex(new AntlrInputStream(input));

        var tokens = new CommonTokenStream(lexer);

        var parser = new GetUMPStx(tokens);

        GetUMPStx.FileContext file = parser.file();

        var visitor = new BasicVisitor();
        visitor.Visit(file);
    }

    public static void ParseFile()
    {

    }
}
