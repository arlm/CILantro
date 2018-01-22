using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadLengthInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var array = state.Stack.Pop() as Array;

            state.Stack.Push(array.Length);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}