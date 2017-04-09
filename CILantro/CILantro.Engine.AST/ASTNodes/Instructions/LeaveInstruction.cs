﻿namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LeaveInstruction : InstructionBranch
    {
        public override int BytesLength => 5;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            return Method.GetInstructionByBranchTarget(this, Target);
        }
    }
}
