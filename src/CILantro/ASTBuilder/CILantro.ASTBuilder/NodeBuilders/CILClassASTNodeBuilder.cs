using CILantro.AST.CILASTNodes;
using Irony.Parsing;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILClassASTNodeBuilder : CILASTNodeBuilder<CILClass>
    {
        public override CILClass BuildNode(ParseTreeNode node)
        {
            return new CILClass();
        }
    }
}