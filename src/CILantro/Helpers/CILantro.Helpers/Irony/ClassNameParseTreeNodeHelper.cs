using CILantro.AST.HelperClasses;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

namespace CILantro.Helpers.Irony
{
    public static class ClassNameParseTreeNodeHelper
    {
        public static CILClassName GetClassName(ParseTreeNode node)
        {
            var name1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.name1);
            var assemblyName = Name1ParseTreeNodeHelper.GetValue(name1ParseTreeNode);

            var slashedNameParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.slashedName);
            var className = SlashedNameParseTreeNodeHelper.GetValue(slashedNameParseTreeNode);

            return new CILClassName
            {
                AssemblyName = assemblyName,
                ClassName = className
            };
        }
    }
}