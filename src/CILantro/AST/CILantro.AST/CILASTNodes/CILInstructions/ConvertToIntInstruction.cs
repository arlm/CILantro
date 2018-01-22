using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class ConvertToIntInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = state.Stack.Pop();

            var result = Convert.ToInt32(value);
            state.Stack.Push(result);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}