using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class BranchOnNotEqualOrUnorderedShortInstruction : CILInstructionBranchTarget
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value2 = state.Stack.Pop();
            var value1 = state.Stack.Pop();

            var intValue1 = Convert.ToInt32(value1);
            var intValue2 = Convert.ToInt32(value2);

            if (intValue1 != intValue2) return ParentMethod.GetInstructionByBranchTarget(Label);
            return ParentMethod.GetNextInstruction(this);
        }
    }
}