using CILantro.State;
using System;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class UnboxAnyInstruction : CILInstructionType
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = state.Stack.Pop();

            var newType = TypeSpecification.GetTypeSpecified();
            var newValue = Convert.ChangeType(value, newType);

            state.Stack.Push(newValue);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}