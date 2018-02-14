using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;
using System.Reflection;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadStaticFieldInstruction : CILInstructionField
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var reflectedType = FieldOwnerTypeSpecification.GetTypeSpecified(programInstance);
            var reflectedField = reflectedType.GetField(FieldName, BindingFlags.Static);

            var value = reflectedField.GetValue(null);
            state.Stack.Push(value);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}