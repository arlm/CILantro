using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class NewArrayInstruction : CILInstructionType
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var elementsCount = (int)state.Stack.Pop();

            var array = Array.CreateInstance(TypeSpecification.GetTypeSpecified(), elementsCount);
            state.Stack.Push(array);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}