using CILantro.AST;
using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder
{
    public abstract class CILASTNodeBuilder<T>
        where T : CILASTNode
    {
        public abstract T BuildNode(ParseTreeNode node);
    }
}