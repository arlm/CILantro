using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadLocalVariableAddressShortInstruction : CILInstructionVar
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var localAddress = ParentMethod.GetLocalAddress(VariableId);
            state.Stack.Push(localAddress);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}