using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionASTNodeBuilder : CILASTNodeBuilder<CILInstruction>
    {
        private readonly CILInstructionMethodASTNodeBuilder _instructionMethodBuilder;

        private readonly CILInstructionNoneASTNodeBuilder _instructionNoneBuilder;

        private readonly CILInstructionStringASTNodeBuilder _instructionStringBuilder;

        private readonly CILInstructionVarASTNodeBuilder _instructionVarBuilder;

        private readonly CILInstructionIASTNodeBuilder _instructionIBuilder;

        private readonly CILInstructionI8ASTNodeBuilder _instructionI8Builder;

        private readonly CILInstructionBranchTargetASTNodeBuilder _instructionBranchTargetBuilder;

        private readonly CILInstructionSwitchASTNodeBuilder _instructionSwitchBuilder;

        private readonly CILInstructionTokASTNodeBuilder _instructionTokBuilder;

        private readonly CILInstructionTypeASTNodeBuilder _instructionTypeBuilder;

        private readonly CILInstructionRASTNodeBuilder _instructionRBuilder;

        private readonly CILInstructionFieldASTNodeBuilder _instructionFieldBuilder;

        public CILInstructionASTNodeBuilder()
        {
            _instructionMethodBuilder = new CILInstructionMethodASTNodeBuilder();
            _instructionNoneBuilder = new CILInstructionNoneASTNodeBuilder();
            _instructionStringBuilder = new CILInstructionStringASTNodeBuilder();
            _instructionVarBuilder = new CILInstructionVarASTNodeBuilder();
            _instructionIBuilder = new CILInstructionIASTNodeBuilder();
            _instructionI8Builder = new CILInstructionI8ASTNodeBuilder();
            _instructionBranchTargetBuilder = new CILInstructionBranchTargetASTNodeBuilder();
            _instructionSwitchBuilder = new CILInstructionSwitchASTNodeBuilder();
            _instructionTokBuilder = new CILInstructionTokASTNodeBuilder();
            _instructionTypeBuilder = new CILInstructionTypeASTNodeBuilder();
            _instructionRBuilder = new CILInstructionRASTNodeBuilder();
            _instructionFieldBuilder = new CILInstructionFieldASTNodeBuilder();
        }

        public override CILInstruction BuildNode(ParseTreeNode node)
        {
            var instrMethodParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_METHOD);
            if (instrMethodParseTreeNode != null)
            {
                var instructionMethod = _instructionMethodBuilder.BuildNode(node);
                return instructionMethod;
            }

            var instrNoneParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_NONE);
            if(instrNoneParseTreeNode != null)
            {
                var instructionNone = _instructionNoneBuilder.BuildNode(node);
                return instructionNone;
            }

            var instrStringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_STRING);
            if(instrStringParseTreeNode != null)
            {
                var instructionString = _instructionStringBuilder.BuildNode(node);
                return instructionString;
            }

            var instrVarParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_VAR);
            if(instrVarParseTreeNode != null)
            {
                var instructionVar = _instructionVarBuilder.BuildNode(node);
                return instructionVar;
            }

            var instrIParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_I);
            if(instrIParseTreeNode != null)
            {
                var instructionI = _instructionIBuilder.BuildNode(node);
                return instructionI;
            }

            var instrI8ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_I8);
            if(instrI8ParseTreeNode != null)
            {
                var instructionI8 = _instructionI8Builder.BuildNode(node);
                return instructionI8;
            }

            var instrBranchTargetParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_BRTARGET);
            if (instrBranchTargetParseTreeNode != null)
            {
                var instructionBranchTarget = _instructionBranchTargetBuilder.BuildNode(node);
                return instructionBranchTarget;
            }

            var instrRParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_R);
            if(instrRParseTreeNode != null)
            {
                var instructionR = _instructionRBuilder.BuildNode(node);
                return instructionR;
            }

            var instrSwitchParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_SWITCH);
            if(instrSwitchParseTreeNode != null)
            {
                var instructionSwitch = _instructionSwitchBuilder.BuildNode(node);
                return instructionSwitch;
            }

            var instrTokHeadParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.instr_tok_head);
            var instrTokParseTreeNode = instrTokHeadParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.INSTR_TOK);
            if(instrTokParseTreeNode != null)
            {
                var instructionTok = _instructionTokBuilder.BuildNode(node);
                return instructionTok;
            }

            var instrTypeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_TYPE);
            if(instrTypeParseTreeNode != null)
            {
                var instructionType = _instructionTypeBuilder.BuildNode(node);
                return instructionType;
            }

            var instrFieldParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_FIELD);
            if(instrFieldParseTreeNode != null)
            {
                var instructionField = _instructionFieldBuilder.BuildNode(node);
                return instructionField;
            }

            throw new ArgumentException("Cannot recognize CIL instruction.");
        }
    }
}