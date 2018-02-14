using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class Int32ParseTreeNodeHelper
    {
        public static int GetValue(ParseTreeNode node)
        {
            var lexicalsInt32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_INT32);
            return LexicalsInt32ParseTreeNodeHelper.GetValue(lexicalsInt32ParseTreeNode);
        }
    }
}