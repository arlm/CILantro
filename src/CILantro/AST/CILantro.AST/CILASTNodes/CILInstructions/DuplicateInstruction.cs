using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class DuplicateInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = state.Stack.Pop();
            state.Stack.Push(value);
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}