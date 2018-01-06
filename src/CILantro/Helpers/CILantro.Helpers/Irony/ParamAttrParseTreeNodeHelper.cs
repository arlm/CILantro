using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

namespace CILantro.Helpers.Irony
{
    public static class ParamAttrParseTreeNodeHelper
    {
        public static int GetNumberAttribute(ParseTreeNode node)
        {
            var int32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.int32);
            return Int32ParseTreeNodeHelper.GetValue(int32ParseTreeNode);
        }
    }
}