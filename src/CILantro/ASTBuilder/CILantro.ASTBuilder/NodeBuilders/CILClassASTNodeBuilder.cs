using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System.Collections.Generic;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILClassASTNodeBuilder : CILASTNodeBuilder<CILClass>
    {
        private readonly CILMethodASTNodeBuilder _methodBuilder;

        public CILClassASTNodeBuilder()
        {
            _methodBuilder = new CILMethodASTNodeBuilder();
        }

        public override CILClass BuildNode(ParseTreeNode node)
        {
            var methods = new List<CILMethod>();

            var classDeclsParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.classDecls);
            while(classDeclsParseTreeNode != null)
            {
                var classDeclParseTreeNode = classDeclsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.classDecl);

                var methodDeclsParseTreeNode = classDeclParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.methodDecls);
                if(methodDeclsParseTreeNode != null)
                {
                    var method = _methodBuilder.BuildNode(classDeclParseTreeNode);
                    methods.Add(method);
                }

                classDeclsParseTreeNode = classDeclsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.classDecls);
            }

            var result = new CILClass
            {
                Methods = methods
            };
            return result;
        }
    }
}