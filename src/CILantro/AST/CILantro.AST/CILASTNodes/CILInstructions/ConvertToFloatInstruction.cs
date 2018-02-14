using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class ConvertToFloatInstruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = state.Stack.Pop();

            var result = Convert.ToSingle(value);
            state.Stack.Push(result);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}