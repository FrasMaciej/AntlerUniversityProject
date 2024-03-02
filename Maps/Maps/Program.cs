// See https://aka.ms/new-console-template for more information
using Antlr4.StringTemplate;
Console.WriteLine("Hello, World!");

var st = new Antlr4.StringTemplate.Template("Hello, <name>!");
st.Add("name", "World from StringTemplate");
Console.WriteLine(st.Render());
