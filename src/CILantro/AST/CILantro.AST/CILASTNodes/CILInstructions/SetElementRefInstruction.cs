using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SetElementRefInstruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = state.Stack.Pop();
            var index = (int)state.Stack.Pop();
            var array = state.Stack.Pop() as Array;

            array.SetValue(value, index);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}