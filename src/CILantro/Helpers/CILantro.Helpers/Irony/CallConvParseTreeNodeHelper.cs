using CILantro.AST.HelperClasses;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

namespace CILantro.Helpers.Irony
{
    public static class CallConvParseTreeNodeHelper
    {
        public static CILCallConvention GetValue(ParseTreeNode node)
        {
            var result = new CILCallConvention();

            var callConvNode = node;
            while(callConvNode != null)
            {
                var instanceParseTreeNode = callConvNode.GetFirstChildWithGrammarName(GrammarNames.keyword_instance);
                if (instanceParseTreeNode != null) result.Instance = true;

                callConvNode = callConvNode.GetFirstChildWithGrammarName(GrammarNames.callConv);
            }

            return result;
        }
    }
}