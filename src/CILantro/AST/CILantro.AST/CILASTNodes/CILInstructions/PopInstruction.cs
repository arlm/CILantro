using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class PopInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            state.Stack.Pop();

            return ParentMethod.GetNextInstruction(this);
        }
    }
}