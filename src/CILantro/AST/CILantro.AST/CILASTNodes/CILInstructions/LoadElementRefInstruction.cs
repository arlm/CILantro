﻿using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadElementRefInstruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var index = (int)state.Stack.Pop();
            var array = state.Stack.Pop() as Array;

            var value = array.GetValue(index);
            state.Stack.Push(value);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}