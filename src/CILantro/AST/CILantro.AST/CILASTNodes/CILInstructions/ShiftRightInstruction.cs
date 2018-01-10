﻿using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class ShiftRightInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value2 = (int)state.Stack.Pop();
            var value1 = (int)state.Stack.Pop();

            var result = value1 >> value2;
            state.Stack.Push(result);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}