using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadArgument3Instruction : CILInstructionNone
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            if (ParentMethod.CallConvention.Instance)
            {
                state.Stack.Push(instructionInstance.MethodInstance.Arguments[2]);
            }
            else
            {
                state.Stack.Push(instructionInstance.MethodInstance.Arguments[3]);
            }

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}