using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

namespace CILantro.Helpers.Irony
{
    public static class SlashedNameParseTreeNodeHelper
    {
        public static string GetValue(ParseTreeNode node)
        {
            var name1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.name1);
            return Name1ParseTreeNodeHelper.GetValue(name1ParseTreeNode);
        }
    }
}