using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt3Instruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            int value = 3;
            state.Stack.Push(value);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}