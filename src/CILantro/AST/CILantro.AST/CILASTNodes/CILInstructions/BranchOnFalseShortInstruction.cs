using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class BranchOnFalseShortInstruction : CILInstructionBranchTarget
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var value = state.Stack.Pop();

            var intValue = Convert.ToInt32(value);

            if (intValue == 0) return ParentMethod.GetInstructionByBranchTarget(Label);
            return ParentMethod.GetNextInstruction(this);
        }
    }
}