using CILantro.AST.HelperClasses;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

namespace CILantro.Helpers.Irony
{
    public static class TypeSpecParseTreeNodeHelper
    {
        public static CILTypeSpecification GetValue(ParseTreeNode node)
        {
            var classNameParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.className);
            var className = ClassNameParseTreeNodeHelper.GetClassName(classNameParseTreeNode);

            return new CILTypeSpecification
            {
                ClassName = className
            };
        }
    }
}