using CILantro.Engine.AST.ASTNodes.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionBranchBuilder : CILASTNodeBuilder<InstructionBranch>
    {
        public override InstructionBranch BuildNode(ParseTreeNode node)
        {
            var target = 0;
            var targetLabel = string.Empty;

            var identifierNode = node.GetChildIdentifierNode();
            if (identifierNode != null)
                targetLabel = identifierNode.Token.ValueString;

            var integerNode = node.GetChildIntegerNode();
            if(integerNode != null)
                target = integerNode.GetIntegerNodeValue();

            var instructionBranchNode = node.GetChildInstructionBranchNode();

            var beqToken = instructionBranchNode.GetChildBeqTokenNode();
            if(beqToken != null)
            {
                return new BranchIfEqualInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var beqsToken = instructionBranchNode.GetChildBeqsTokenNode();
            if(beqsToken != null)
            {
                return new BranchIfEqualShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bgeToken = instructionBranchNode.GetChildBgeTokenNode();
            if(bgeToken != null)
            {
                return new BranchIfGreaterOrEqualInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bgesToken = instructionBranchNode.GetChildBgesTokenNode();
            if(bgesToken != null)
            {
                return new BranchIfGreaterOrEqualShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bgeunToken = instructionBranchNode.GetChildBgeunTokenNode();
            if(bgeunToken != null)
            {
                return new BranchIfGreaterOrEqualUnsignedInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bgeunsToken = instructionBranchNode.GetChildBgeunsTokenNode();
            if(bgeunsToken != null)
            {
                return new BranchIfGreaterOrEqualUnsignedShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bgtToken = instructionBranchNode.GetChildBgtTokenNode();
            if(bgtToken != null)
            {
                return new BranchIfGreaterInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bgtsToken = instructionBranchNode.GetChildBgtsTokenNode();
            if(bgtsToken != null)
            {
                return new BranchIfGreaterShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bgtunToken = instructionBranchNode.GetChildBgtunTokenNode();
            if(bgtunToken != null)
            {
                return new BranchIfGreaterUnsignedInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bgtunsToken = instructionBranchNode.GetChildBgtunsTokenNode();
            if(bgtunsToken != null)
            {
                return new BranchIfGreaterUnsignedShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bleToken = instructionBranchNode.GetChildBleTokenNode();
            if(bleToken != null)
            {
                return new BranchIfLessOrEqualInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var blesToken = instructionBranchNode.GetChildBlesTokenNode();
            if(blesToken != null)
            {
                return new BranchIfLessOrEqualShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bleunToken = instructionBranchNode.GetChildBleunTokenNode();
            if(bleunToken != null)
            {
                return new BranchIfLessOrEqualUnsignedInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bleunsToken = instructionBranchNode.GetChildBleunsTokenNode();
            if(bleunsToken != null)
            {
                return new BranchIfLessOrEqualUnsignedShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bltToken = instructionBranchNode.GetChildBltTokenNode();
            if(bltToken != null)
            {
                return new BranchIfLessInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bltsToken = instructionBranchNode.GetChildBltsTokenNode();
            if(bltsToken != null)
            {
                return new BranchIfLessShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bltunToken = instructionBranchNode.GetChildBltunTokenNode();
            if(bltunToken != null)
            {
                return new BranchIfLessUnsignedInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bltunsToken = instructionBranchNode.GetChildBltunsTokenNode();
            if(bltunsToken != null)
            {
                return new BranchIfLessUnsignedShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bneunToken = instructionBranchNode.GetChildBneunTokenNode();
            if(bneunToken != null)
            {
                return new BranchIfNotEqualUnsignedInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var bneunsToken = instructionBranchNode.GetChildBneunsTokenNode();
            if(bneunsToken != null)
            {
                return new BranchIfNotEqualUnsignedShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var brToken = instructionBranchNode.GetChildBrTokenNode();
            if(brToken != null)
            {
                return new BranchInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var brsToken = instructionBranchNode.GetChildBrsTokenNode();
            if(brsToken != null)
            {
                return new BranchShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var brfalseToken = instructionBranchNode.GetChildBrfalseTokenNode();
            if(brfalseToken != null)
            {
                return new BranchIfFalseInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var brfalsesToken = instructionBranchNode.GetChildBrfalsesTokenNode();
            if(brfalsesToken != null)
            {
                return new BranchIfFalseShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var brtrueToken = instructionBranchNode.GetChildBrtrueTokenNode();
            if(brtrueToken != null)
            {
                return new BranchIfTrueInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var brtruesToken = instructionBranchNode.GetChildBrtruesTokenNode();
            if (brtruesToken != null)
            {
                return new BranchIfTrueShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var leaveToken = instructionBranchNode.GetChildLeaveTokenNode();
            if(leaveToken != null)
            {
                return new LeaveInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            var leavesToken = instructionBranchNode.GetChildLeavesTokenNode();
            if(leavesToken != null)
            {
                return new LeaveShortInstruction
                {
                    Target = target,
                    TargetLabel = targetLabel
                };
            }

            throw new ArgumentException("Cannot recognize instruction branch.");
        }
    }
}