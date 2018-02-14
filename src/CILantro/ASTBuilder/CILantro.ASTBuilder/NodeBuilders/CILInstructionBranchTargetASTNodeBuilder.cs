using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionBranchTargetASTNodeBuilder : CILASTNodeBuilder<CILInstructionBranchTarget>
    {
        public override CILInstructionBranchTarget BuildNode(ParseTreeNode node)
        {
            var instructionBranchTargetParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_BRTARGET);

            CILInstructionBranchTarget result = null;

            var beqsParseTreeNode = instructionBranchTargetParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_beqs);
            if(beqsParseTreeNode != null)
            {
                result = new BranchOnEqualShortInstruction();
            }

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

            var bltsParseTreeNode = instructionBranchTargetParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_blts);
            if(bltsParseTreeNode != null)
            {
                result = new BranchOnLessShortInstruction();
            }

            var bneunsParseTreeNode = instructionBranchTargetParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_bneuns);
            if(bneunsParseTreeNode != null)
            {
                result = new BranchOnNotEqualOrUnorderedShortInstruction();
            }

            var brParseTreeNode = instructionBranchTargetParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_br);
            if (brParseTreeNode != null)
            {
                result = new BranchInstruction();
            }

            var brfalsesParseTreeNode = instructionBranchTargetParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_brfalses);
            if(brfalsesParseTreeNode != null)
            {
                result = new BranchOnFalseShortInstruction();
            }

            var brsParseTreeNode = instructionBranchTargetParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_brs);
            if(brsParseTreeNode != null)
            {
                result = new BranchShortInstruction();
            }

            var brtruesParseTreeNode = instructionBranchTargetParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_brtrues);
            if(brtruesParseTreeNode != null)
            {
                result = new BranchOnTrueShortInstruction();
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