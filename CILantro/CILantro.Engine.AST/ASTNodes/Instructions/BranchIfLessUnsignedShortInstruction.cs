﻿namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfLessUnsignedShortInstruction : InstructionBranch
    {
        public override int BytesLength => 2;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value2 = (int)state.Stack.Pop();
            var value1 = (int)state.Stack.Pop();

            if (value1 < value2) return Method.GetInstructionByBranchTarget(this, Target, TargetLabel);
            return Method.GetNextInstruction(this);
        }
    }
}