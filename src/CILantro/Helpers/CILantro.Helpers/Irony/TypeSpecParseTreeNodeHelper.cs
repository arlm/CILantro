using CILantro.AST.HelperClasses;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class TypeSpecParseTreeNodeHelper
    {
        public static CILTypeSpecification GetValue(ParseTreeNode node)
        {
            CILClassName className = null;
            CILType type = null;

            var classNameParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.className);
            if(classNameParseTreeNode != null)
            {
                className = ClassNameParseTreeNodeHelper.GetClassName(classNameParseTreeNode);
            }

            var typeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.type);
            if(typeParseTreeNode != null)
            {
                type = TypeParseTreeNodeHelper.GetType(typeParseTreeNode);
            }

            return new CILTypeSpecification
            {
                ClassName = className,
                Type = type
            };
        }
    }
}