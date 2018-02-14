using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILModuleASTNodeBuilder : CILASTNodeBuilder<CILModule>
    {
        public override CILModule BuildNode(ParseTreeNode node)
        {
            var result = new CILModule();

            var name1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.name1);
            var moduleName = Name1ParseTreeNodeHelper.GetValue(name1ParseTreeNode);
            result.ModuleName = moduleName;

            return result;
        }
    }
}