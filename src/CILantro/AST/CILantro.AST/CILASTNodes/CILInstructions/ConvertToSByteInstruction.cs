﻿using CILantro.AST.CILInstances;
using CILantro.Helpers.Convertions;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class ConvertToSByteInstruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = state.Stack.Pop();

            var result = ConvertHelper.ToSByte(value);
            state.Stack.Push(result);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}