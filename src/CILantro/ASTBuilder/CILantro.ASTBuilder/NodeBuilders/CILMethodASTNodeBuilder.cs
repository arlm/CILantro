using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILMethodASTNodeBuilder : CILASTNodeBuilder<CILMethod>
    {
        public override CILMethod BuildNode(ParseTreeNode node)
        {
            var isEntryPoint = false;

            var methodDeclsParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.methodDecls);
            while(methodDeclsParseTreeNode != null)
            {
                var methodDeclParseTreeNode = methodDeclsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.methodDecl);

                var dotEntrypointParseTreeNode = methodDeclParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.dotEntrypoint);
                if(dotEntrypointParseTreeNode != null)
                {
                    isEntryPoint = true;
                }

                methodDeclsParseTreeNode = methodDeclsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.methodDecls);
            }

            var result = new CILMethod(isEntryPoint);
            return result;
        }
    }
}