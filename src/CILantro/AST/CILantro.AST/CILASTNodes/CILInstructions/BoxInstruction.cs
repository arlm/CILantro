using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class BoxInstruction : CILInstructionType
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = state.Stack.Pop();

            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}