using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadTokenInstruction : CILInstructionTok
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var typeSpecified = OwnerType.TypeSpecification.GetTypeSpecified(programInstance);
            var typeHandle = typeSpecified.TypeHandle;
            state.Stack.Push(typeHandle);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}