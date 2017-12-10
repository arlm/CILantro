using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System.Collections.Generic;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILMethodASTNodeBuilder : CILASTNodeBuilder<CILMethod>
    {
        private readonly CILInstructionASTNodeBuilder _instructionBuilder;

        public CILMethodASTNodeBuilder()
        {
            _instructionBuilder = new CILInstructionASTNodeBuilder();
        }

        public override CILMethod BuildNode(ParseTreeNode node)
        {
            var instructions = new List<CILInstruction>();
            var isEntryPoint = false;

            var methodDeclsParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.methodDecls);
            while(methodDeclsParseTreeNode != null)
            {
                var methodDeclParseTreeNode = methodDeclsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.methodDecl);

                var instrParseTreeNode = methodDeclParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.instr);
                if(instrParseTreeNode != null)
                {
                    var instruction = _instructionBuilder.BuildNode(instrParseTreeNode);
                    instructions.Add(instruction);
                }

                var dotEntrypointParseTreeNode = methodDeclParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.dotEntrypoint);
                if(dotEntrypointParseTreeNode != null)
                {
                    isEntryPoint = true;
                }

                methodDeclsParseTreeNode = methodDeclsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.methodDecls);
            }

            instructions.Reverse();

            var result = new CILMethod
            {
                Instructions = instructions,
                IsEntryPoint = isEntryPoint
            };

            foreach (var instruction in instructions)
            {
                instruction.ParentMethod = result;
            }

            return result;
        }
    }
}