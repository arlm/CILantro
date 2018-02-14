using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class XorInstruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value2 = (int)state.Stack.Pop();
            var value1 = (int)state.Stack.Pop();

            var result = value1 ^ value2;
            state.Stack.Push(result);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}