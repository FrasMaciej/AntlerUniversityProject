using Antlr4.Runtime.Misc;

namespace Maps
{
    public class BasicVisitor : GetUMPStxBaseVisitor<object>
    {
        public static int SectionCount { get; set; } = 0;
        public BasicVisitor()
        {
            
        }

        public override object VisitFile([NotNull] GetUMPStx.FileContext context)
        {
            var result = base.VisitFile(context);
            Console.WriteLine(SectionCount);
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