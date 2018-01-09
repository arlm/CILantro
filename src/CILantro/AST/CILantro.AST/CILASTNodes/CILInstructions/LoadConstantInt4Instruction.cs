using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt4Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            int value = 4;
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}