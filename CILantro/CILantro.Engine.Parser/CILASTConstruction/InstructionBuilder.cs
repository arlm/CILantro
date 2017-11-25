using CILantro.Engine.AST.ASTNodes;
using CILantro.Engine.Parser.CILASTConstruction.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System;

namespace CILantro.Engine.Parser.CILASTConstruction
{
    public class InstructionBuilder : CILASTNodeBuilder<CILInstruction>
    {
        private InstructionNoneBuilder _instructionNoneBuilder;
        private InstructionMethodBuilder _instructionMethodBuilder;
        private InstructionStringBuilder _instructionStringBuilder;
        private InstructionIntBuilder _instructionIntBuilder;
        private InstructionBranchBuilder _instructionBranchBuilder;
        private InstructionSwitchBuilder _instructionSwitchBuilder;

        public InstructionBuilder()
        {
            _instructionNoneBuilder = new InstructionNoneBuilder();
            _instructionMethodBuilder = new InstructionMethodBuilder();
            _instructionStringBuilder = new InstructionStringBuilder();
            _instructionIntBuilder = new InstructionIntBuilder();
            _instructionBranchBuilder = new InstructionBranchBuilder();
            _instructionSwitchBuilder = new InstructionSwitchBuilder();
        }

        public override CILInstruction BuildNode(ParseTreeNode node)
        {
            var instructionNoneNode = node.GetChildInstructionNoneNode();
            if (instructionNoneNode != null)
                return _instructionNoneBuilder.BuildNode(node);

            var instructionMethodNode = node.GetChildInstructionMethodNode();
            if (instructionMethodNode != null)
                return _instructionMethodBuilder.BuildNode(node);

            var instructionStringNode = node.GetChildInstructionStringNode();
            if (instructionStringNode != null)
                return _instructionStringBuilder.BuildNode(node);

            var instructionIntNode = node.GetChildInstructionIntNode();
            if (instructionIntNode != null)
                return _instructionIntBuilder.BuildNode(node);

            var instructionBranchNode = node.GetChildInstructionBranchNode();
            if (instructionBranchNode != null)
                return _instructionBranchBuilder.BuildNode(node);

            var instructionSwitchNode = node.GetChildInstructionSwitchNode();
            if (instructionSwitchNode != null)
                return _instructionSwitchBuilder.BuildNode(node);

            throw new ArgumentException("Cannot recognize instruction.");
        }
    }
}
