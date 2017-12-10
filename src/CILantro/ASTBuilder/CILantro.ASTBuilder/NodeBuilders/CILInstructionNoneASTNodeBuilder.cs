using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionNoneASTNodeBuilder : CILASTNodeBuilder<CILInstructionNone>
    {
        public override CILInstructionNone BuildNode(ParseTreeNode node)
        {
            var instrNoneParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_NONE);

            var ldarg0ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.ldarg0);
            if(ldarg0ParseTreeNode != null)
            {
                var loadArgument0Instruction = new LoadArgument0Instruction();
                return loadArgument0Instruction;
            }

            var retParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.ret);
            if(retParseTreeNode != null)
            {
                var returnInstruction = new ReturnInstruction();
                return returnInstruction;
            }

            throw new ArgumentException("Cannot recognize CIL instruction none.");
        }
    }
}