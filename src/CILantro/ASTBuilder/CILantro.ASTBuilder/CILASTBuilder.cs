using CILantro.AST.CILASTNodes;
using CILantro.ASTBuilder.NodeBuilders;
using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder
{
    public class CILASTBuilder
    {
        private readonly CILRootASTNodeBuilder _rootBuilder;

        public CILASTBuilder()
        {
            _rootBuilder = new CILRootASTNodeBuilder();
        }

        public CILProgram BuildAST(ParseTree parseTree)
        {
            var programTree = _rootBuilder.BuildNode(parseTree.Root);
            return programTree;
        }
    }
}