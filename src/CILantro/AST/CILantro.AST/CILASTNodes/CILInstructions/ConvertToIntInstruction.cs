using CILantro.AST.CILInstances;
using CILantro.Helpers.Convertions;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class ConvertToIntInstruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = state.Stack.Pop();

            var result = ConvertHelper.ToInt(value);
            state.Stack.Push(result);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}