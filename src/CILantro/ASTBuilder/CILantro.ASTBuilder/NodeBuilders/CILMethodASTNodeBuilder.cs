using CILantro.AST.CILASTNodes;
using Irony.Parsing;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILMethodASTNodeBuilder : CILASTNodeBuilder<CILMethod>
    {
        public override CILMethod BuildNode(ParseTreeNode node)
        {
            var result = new CILMethod(false);
            return result;
        }
    }
}