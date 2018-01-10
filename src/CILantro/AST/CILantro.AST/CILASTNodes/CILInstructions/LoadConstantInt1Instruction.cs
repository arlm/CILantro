using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt1Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            int value = 1;
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}