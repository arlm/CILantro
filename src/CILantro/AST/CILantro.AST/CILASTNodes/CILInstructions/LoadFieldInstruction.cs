using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadFieldInstruction : CILInstructionField
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var instance = state.Stack.Pop();

            var reflectedType = FieldOwnerTypeSpecification.GetTypeSpecified(programInstance);
            var reflectedField = reflectedType.GetField(FieldName);

            var value = reflectedField.GetValue(instance);
            state.Stack.Push(value);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}