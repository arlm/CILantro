using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadFieldAddressInstruction : CILInstructionField
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var instance = state.Stack.Pop();

            var cilClassInstance = instance as CILClassInstance;

            var address = cilClassInstance.GetField(FieldName);
            state.Stack.Push(address);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}