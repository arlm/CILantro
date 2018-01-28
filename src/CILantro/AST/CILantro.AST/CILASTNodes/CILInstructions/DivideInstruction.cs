using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class DivideInstruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var val2 = (int)state.Stack.Pop();
            var val1 = (int)state.Stack.Pop();
            var result = val1 / val2;
            state.Stack.Push(result);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}