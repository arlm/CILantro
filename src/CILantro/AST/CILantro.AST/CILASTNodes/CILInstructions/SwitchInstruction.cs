using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SwitchInstruction : CILInstructionSwitch
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = state.Stack.Pop();

            var intValue = Convert.ToInt32(value);
            
            if(intValue >= 0 && intValue < Labels.Count)
            {
                var switchLabel = Labels[intValue];
                return instructionInstance.GetInstructionInstanceByBranchTarget(switchLabel);
            }

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}