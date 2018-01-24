using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

namespace CILantro.Helpers.Irony
{
    public static class Float64ParseTreeNodeHelper
    {
        public static double GetValue(ParseTreeNode node)
        {
            var lexicalsFloat64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_FLOAT64);
            return LexicalsFloat64ParseTreeNodeHelper.GetValue(lexicalsFloat64ParseTreeNode);
        }
    }
}