using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt0Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            int value = 0;
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}