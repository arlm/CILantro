using CILantro.AST.HelperClasses;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

namespace CILantro.Helpers.Irony
{
    public static class OwnerTypeParseTreeNodeHelper
    {
        public static CILOwnerType GetValue(ParseTreeNode node)
        {
            var result = new CILOwnerType();

            var typeSpecParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.typeSpec);
            result.TypeSpecification = TypeSpecParseTreeNodeHelper.GetValue(typeSpecParseTreeNode);

            return result;
        }
    }
}