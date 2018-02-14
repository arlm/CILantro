using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILAssemblyASTNodeBuilder : CILASTNodeBuilder<CILAssembly>
    {
        public override CILAssembly BuildNode(ParseTreeNode node)
        {
            var result = new CILAssembly();

            var assemblyHeadParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.assemblyHead);
            var assemblyHeadName1ParseTreeNode = assemblyHeadParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.name1);
            var assemblyName = Name1ParseTreeNodeHelper.GetValue(assemblyHeadName1ParseTreeNode);
            result.AssemblyName = assemblyName;

            return result;
        }
    }
}