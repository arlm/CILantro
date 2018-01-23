﻿using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SetElementIntInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = (int)state.Stack.Pop();
            var index = (int)state.Stack.Pop();
            var array = state.Stack.Pop() as Array;

            array.SetValue(value, index);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}