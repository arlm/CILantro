using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SetStaticFieldInstruction : CILInstructionField
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = state.Stack.Pop();

            var reflectedType = FieldOwnerTypeSpecification.GetTypeSpecified(programInstance);
            var reflectedField = reflectedType.GetField(FieldName);
            reflectedField.SetValue(null, value);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}