﻿using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadArgumentShortInstruction : CILInstructionVar
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            state.Stack.Push(instructionInstance.MethodInstance.Arguments[VariableId]);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}