using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

namespace CILantro.Helpers.Irony
{
    public static class IdParseTreeNodeHelper
    {
        public static string GetValue(ParseTreeNode node)
        {
            var lexicalsIdParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_ID);
            return lexicalsIdParseTreeNode.Token.ValueString;
        }
    }
}