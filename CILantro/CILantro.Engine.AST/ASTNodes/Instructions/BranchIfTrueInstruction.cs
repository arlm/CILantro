using System;

namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfTrueInstruction : InstructionBranch
    {
        public override int BytesLength => 5;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value = Convert.ToBoolean(state.Stack.Pop());

            if (!value) return Method.GetNextInstruction(this);
            return Method.GetInstructionByBranchTarget(this, Target, TargetLabel);
        }
    }
}