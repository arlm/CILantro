using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadArgument2Instruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            if(ParentMethod.IsConstructor)
            {
                state.Stack.Push(instructionInstance.MethodInstance.Arguments[1]);
            }
            else
            {
                state.Stack.Push(instructionInstance.MethodInstance.Arguments[2]);
            }

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}