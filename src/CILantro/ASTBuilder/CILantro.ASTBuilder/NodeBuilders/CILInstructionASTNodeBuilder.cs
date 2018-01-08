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

        public CILInstructionASTNodeBuilder()
        {
            _instructionMethodBuilder = new CILInstructionMethodASTNodeBuilder();
            _instructionNoneBuilder = new CILInstructionNoneASTNodeBuilder();
            _instructionStringBuilder = new CILInstructionStringASTNodeBuilder();
            _instructionVarBuilder = new CILInstructionVarASTNodeBuilder();
            _instructionIBuilder = new CILInstructionIASTNodeBuilder();
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

            throw new ArgumentException("Cannot recognize CIL instruction.");
        }
    }
}