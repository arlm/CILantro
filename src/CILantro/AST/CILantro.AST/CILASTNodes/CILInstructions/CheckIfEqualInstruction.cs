using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class CheckIfEqualInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value2 = state.Stack.Pop();
            var value1 = state.Stack.Pop();

            var intValue1 = Convert.ToInt32(value1);
            var intValue2 = Convert.ToInt32(value2);

            var result = intValue1 == intValue2;
            state.Stack.Push(result);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}