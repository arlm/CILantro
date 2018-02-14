using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class CompQstringParseTreeNodeHelper
    {
        public static string GetValue(ParseTreeNode node)
        {
            var lexicalsQstringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_QSTRING);
            return lexicalsQstringParseTreeNode.Token.ValueString;
        }
    }
}