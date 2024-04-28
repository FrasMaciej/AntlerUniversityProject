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

    public static void TestParseFile([FromService] ILogger<AppCommandDefinitions> logger)
    {
        string input;

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        //input = File.ReadAllText("wynik.mp",Encoding.GetEncoding("ISO-8859-1"));
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        if(filename == null)
        {
            logger.LogError("No filename provided");
            return;
        }
        input = File.ReadAllText(filename, Encoding.GetEncoding(1250));

        var lexer = new GetUMPLex(new AntlrInputStream(input));

        var tokens = new CommonTokenStream(lexer);

        var parser = new GetUMPStx(tokens);

        GetUMPStx.FileContext file = parser.file();

        var visitor = new BasicVisitor();
        visitor.Visit(file);
    }

    public static void ParseFile([FromService] MyDbContext context, [FromService] ILogger<AppCommandDefinitions> logger)
    {
        // string filename = "wynik.mp";
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        if(filename == null)
        {
            logger.LogError("No filename provided");
            return;
        }
        string input;

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        //input = File.ReadAllText("wynik.mp",Encoding.GetEncoding("ISO-8859-1"));
        input = File.ReadAllText(filename, Encoding.GetEncoding(1250));

        logger.LogInformation($"Map from {filename} read at {DateTime.Now}");

        var lexer = new GetUMPLex(new AntlrInputStream(input));

        var tokens = new CommonTokenStream(lexer);

        var parser = new GetUMPStx(tokens);

        GetUMPStx.FileContext file = parser.file();

        logger.LogInformation($"Map from {filename} successfully parsed at {DateTime.Now}");

        var visitor = new BasicVisitor();
        visitor.Visit(file);
        logger.LogInformation($"Map from {filename} successfully visited at {DateTime.Now}");
        var map = visitor.currentMap;
        map.Bytes = File.ReadAllBytes(filename);
        map.FileName = filename;
        map.Description = $"Map from {filename} Imported at {DateTime.Now}";
        

        context.Maps.Add(visitor.currentMap);

        logger.LogInformation($"Map from {filename} successfully added to context at {DateTime.Now}");
        logger.LogInformation($"Started uploading data to db at {DateTime.Now}");

        context.SaveChanges();
        logger.LogInformation($"Map from {filename} successfully uploaded at {DateTime.Now}");
    }
}
