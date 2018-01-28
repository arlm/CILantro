using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class BranchOnNotEqualOrUnorderedShortInstruction : CILInstructionBranchTarget
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value2 = state.Stack.Pop();
            var value1 = state.Stack.Pop();

            var intValue1 = Convert.ToInt32(value1);
            var intValue2 = Convert.ToInt32(value2);

            if (intValue1 != intValue2) return instructionInstance.GetInstructionInstanceByBranchTarget(Label);
            return instructionInstance.GetNextInstructionInstance();
        }
    }
}