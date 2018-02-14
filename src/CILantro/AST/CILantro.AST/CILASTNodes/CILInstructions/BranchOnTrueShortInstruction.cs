using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class BranchOnTrueShortInstruction : CILInstructionBranchTarget
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = state.Stack.Pop();

            var intValue = Convert.ToInt32(value);

            if (intValue != 0) return instructionInstance.GetInstructionInstanceByBranchTarget(Label);
            return instructionInstance.GetNextInstructionInstance();
        }
    }
}