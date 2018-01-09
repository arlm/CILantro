using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt5Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            int value = 5;
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}