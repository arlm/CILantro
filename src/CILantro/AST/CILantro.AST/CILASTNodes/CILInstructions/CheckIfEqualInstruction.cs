﻿using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class CheckIfEqualInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var value2 = state.Stack.Pop();
            var value1 = state.Stack.Pop();

            var result = 0;
            if (value1 is bool && value2 is bool && (bool)value1 == (bool)value2) result = 1;
            if (value1 is int && value2 is int && (int)value1 == (int)value2) result = 1;

            state.Stack.Push(result);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}