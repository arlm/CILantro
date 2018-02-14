using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILExternalAssemblyASTNodeBuilder : CILASTNodeBuilder<CILExternalAssembly>
    {
        public override CILExternalAssembly BuildNode(ParseTreeNode node)
        {
            var result = new CILExternalAssembly();

            var assemblyRefHeadParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.assemblyRefHead);
            var assemblyRefHeadName1ParseTreeNode = assemblyRefHeadParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.name1);
            var assemblyName = Name1ParseTreeNodeHelper.GetValue(assemblyRefHeadName1ParseTreeNode);
            result.AssemblyName = assemblyName;

            return result;
        }
    }
}