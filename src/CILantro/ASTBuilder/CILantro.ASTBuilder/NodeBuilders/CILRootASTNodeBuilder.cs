using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System.Collections.Generic;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILRootASTNodeBuilder : CILASTNodeBuilder<CILProgram>
    {
        private readonly CILClassASTNodeBuilder _classBuilder;

        public CILRootASTNodeBuilder()
        {
            _classBuilder = new CILClassASTNodeBuilder();
        }

        public override CILProgram BuildNode(ParseTreeNode node)
        {
            var classes = new List<CILClass>();

            var declsParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.decls);
            while(declsParseTreeNode != null)
            {
                var declParseTreeNode = declsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.decl);

                var classDeclsParseTreeNode = declParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.classDecls);
                if(classDeclsParseTreeNode != null)
                {
                    var cilClass = _classBuilder.BuildNode(declParseTreeNode);
                    classes.Add(cilClass);
                }

                declsParseTreeNode = declsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.decls);
            }

            var result = new CILProgram
            {
                Classes = classes
            };
            return result;
        }
    }
}