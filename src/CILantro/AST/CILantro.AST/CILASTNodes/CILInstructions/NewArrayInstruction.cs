using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class NewArrayInstruction : CILInstructionType
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var elementsCount = Convert.ToInt32(state.Stack.Pop());

            var array = Array.CreateInstance(TypeSpecification.GetTypeSpecified(programInstance), elementsCount);
            state.Stack.Push(array);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}