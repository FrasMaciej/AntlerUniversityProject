using Antlr4.Runtime;
using System.Text;
using Npgsql;
using Cocona;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Maps;
using Maps.Persistence;
using NetTopologySuite.Geometries;

var builder = CoconaApp.CreateBuilder();

builder.Configuration.AddJsonFile("appsettings.json", true).AddEnvironmentVariables().AddUserSecrets<Program>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
/*var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
dataSourceBuilder.UseNetTopologySuite();
var dataSource = dataSourceBuilder.Build();*/

builder.Services.AddDbContext<MyDbContext>(options => {
    options.UseNpgsql(connectionString, x=>x.UseNetTopologySuite());
    } );

var app = builder.Build();

app.AddCommand("testdb", AppCommandDefinitions.TestDb);
app.AddCommand(AppCommandDefinitions.TestDb);

app.Run();

Console.WriteLine("Hello, World!");

var st = new Antlr4.StringTemplate.Template("Hello, <name>!");
st.Add("name", "World from StringTemplate");
Console.WriteLine(st.Render());

string input;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
//input = File.ReadAllText("wynik.mp",Encoding.GetEncoding("ISO-8859-1"));
input = File.ReadAllText("wynik.mp",Encoding.GetEncoding(1250));

var lexer = new GetUMPLex(new AntlrInputStream(input));

var tokens = new CommonTokenStream(lexer);

var parser = new GetUMPStx(tokens);

GetUMPStx.FileContext file = parser.file();

var visitor = new BasicVisitor();
visitor.Visit(file);

Console.ReadLine();