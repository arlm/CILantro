using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadElementRefInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var index = (int)state.Stack.Pop();
            var array = state.Stack.Pop() as Array;

            var value = array.GetValue(index);
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}