// See https://aka.ms/new-console-template for more information
using Antlr4.StringTemplate;
using Antlr4.Runtime;
using System.Text;
using Maps;
using Antlr4.Runtime.Tree;

Console.WriteLine("Hello, World!");

var st = new Antlr4.StringTemplate.Template("Hello, <name>!");
st.Add("name", "World from StringTemplate");
Console.WriteLine(st.Render());

string input;

using(FileStream fs = new FileStream("ikonki-reczniak.txt", FileMode.Open, FileAccess.Read))
{
    using(StreamReader sr = new StreamReader(fs))
    {
        input = sr.ReadToEnd();
    }
}


var lexer = new GetUMPLex(new AntlrInputStream(input));

var tokens = new CommonTokenStream(lexer);

var parser = new GetUMPStx(tokens);

GetUMPStx.FileContext file = parser.file();

var visitor = new BasicVisitor();
visitor.Visit(file);

Console.ReadLine();