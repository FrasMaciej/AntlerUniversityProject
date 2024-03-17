// See https://aka.ms/new-console-template for more information
using Antlr4.StringTemplate;
using Antlr4.Runtime;
using System.Text;
using testcsharp2;
Console.WriteLine("Hello, World!");

var st = new Antlr4.StringTemplate.Template("Hello, <name>!");
st.Add("name", "World from StringTemplate");
Console.WriteLine(st.Render());




string input = "";

StringBuilder text = new StringBuilder();
Console.WriteLine("Input the chat.");
while((input = Console.ReadLine() ?? throw new Exception()) != "u0004")
{
    text.AppendLine(input);
}

AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
SpeakLexer speakLexer = new SpeakLexer(inputStream);
CommonTokenStream commonTokenStream = new CommonTokenStream(speakLexer);
SpeakParser speakParser = new SpeakParser(commonTokenStream);

SpeakParser.ChatContext chatContext = speakParser.chat();
BasicSpeakVisitor visitor = new BasicSpeakVisitor();
visitor.Visit(chatContext);
foreach(var line in visitor.Lines)
{
    Console.WriteLine("{0} has said {1}", line.Person, line.Text);
}

Console.ReadLine();