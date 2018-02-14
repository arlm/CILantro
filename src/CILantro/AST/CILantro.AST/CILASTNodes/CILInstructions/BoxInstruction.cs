using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class BoxInstruction : CILInstructionType
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = state.Stack.Pop();

            state.Stack.Push(value);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}