using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class ReturnInstruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            if(ParentMethod.IsConstructor)
            {
                state.Stack.Push(instructionInstance.MethodInstance.This);
                return callStack.Pop();
            }
            else if(!ParentMethod.IsEntryPoint)
            {
                return callStack.Pop();
            }

            return null;
        }
    }
}