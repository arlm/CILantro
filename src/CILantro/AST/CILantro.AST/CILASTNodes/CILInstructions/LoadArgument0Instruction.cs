using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadArgument0Instruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            if(ParentMethod.CallConvention.Instance)
            {
                state.Stack.Push(instructionInstance.MethodInstance.This);
            }
            else
            {
                state.Stack.Push(instructionInstance.MethodInstance.Arguments[0]);
            }

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}