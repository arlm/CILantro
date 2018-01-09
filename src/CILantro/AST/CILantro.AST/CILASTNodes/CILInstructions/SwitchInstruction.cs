using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SwitchInstruction : CILInstructionSwitch
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var value = state.Stack.Pop();

            var intValue = Convert.ToInt32(value);
            
            if(intValue >= 0 && intValue < Labels.Count)
            {
                var switchLabel = Labels[intValue];
                return ParentMethod.GetInstructionByBranchTarget(switchLabel);
            }

            return ParentMethod.GetNextInstruction(this);
        }
    }
}