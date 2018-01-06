using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

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
            var localsTypes = new List<Type>();
            var locals = new OrderedDictionary();

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

                var dotEntrypointParseTreeNode = methodDeclParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_dotEntrypoint);
                if(dotEntrypointParseTreeNode != null)
                {
                    isEntryPoint = true;
                }

                var localsHeadParseTreeNode = methodDeclParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.localsHead);
                if(localsHeadParseTreeNode != null)
                {
                    var sigArgs0ParseTreeNode = methodDeclParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.sigArgs0);

                    localsTypes = SigArgs0ParseTreeNodeHelper.GetTypes(sigArgs0ParseTreeNode);
                    locals = SigArgs0ParseTreeNodeHelper.GetLocalsDictionary(sigArgs0ParseTreeNode);
                }

                methodDeclsParseTreeNode = methodDeclsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.methodDecls);
            }

            instructions.Reverse();

            var result = new CILMethod
            {
                Instructions = instructions,
                IsEntryPoint = isEntryPoint,
                LocalsTypes = localsTypes,
                Locals = locals
            };

            foreach (var instruction in instructions)
            {
                instruction.ParentMethod = result;
            }

            return result;
        }
    }
}