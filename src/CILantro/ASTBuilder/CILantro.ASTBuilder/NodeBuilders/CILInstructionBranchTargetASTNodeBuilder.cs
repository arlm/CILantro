using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionBranchTargetASTNodeBuilder : CILASTNodeBuilder<CILInstructionBranchTarget>
    {
        public override CILInstructionBranchTarget BuildNode(ParseTreeNode node)
        {
            var instructionBranchTargetParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_BRTARGET);

            CILInstructionBranchTarget result = null;

            var bgesParseTreeNode = instructionBranchTargetParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_bges);
            if(bgesParseTreeNode != null)
            {
                result = new BranchOnGreaterOrEqualShortInstruction();
            }

            var blesParseTreeNode = instructionBranchTargetParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_bles);
            if(blesParseTreeNode != null)
            {
                result = new BranchOnLessOrEqualShortInstruction();
            }

            if(result != null)
            {
                var idParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.id);
                result.Label = IdParseTreeNodeHelper.GetValue(idParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction branch target.");
        }
    }
}