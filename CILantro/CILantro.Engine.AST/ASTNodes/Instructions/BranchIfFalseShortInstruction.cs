using System;

namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfFalseShortInstruction : InstructionBranch
    {
        public override int BytesLength => 2;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value = Convert.ToBoolean(state.Stack.Pop());

            if (!value) return Method.GetInstructionByBranchTarget(this, Target, TargetLabel);
            return Method.GetNextInstruction(this);
        }
    }
}