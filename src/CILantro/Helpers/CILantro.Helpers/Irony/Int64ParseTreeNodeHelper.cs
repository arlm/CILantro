using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class Int64ParseTreeNodeHelper
    {
        public static long GetValue(ParseTreeNode node)
        {
            var lexicalsInt64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_INT64);
            return LexicalsInt64ParseTreeNodeHelper.GetValue(lexicalsInt64ParseTreeNode);
        }
    }
}