using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt6Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            int value = 6;
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}