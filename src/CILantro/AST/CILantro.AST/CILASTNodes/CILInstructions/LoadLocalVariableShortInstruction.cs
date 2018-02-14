using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadLocalVariableShortInstruction : CILInstructionVar
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = ParentMethod.Locals[VariableId];
            state.Stack.Push(value);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}