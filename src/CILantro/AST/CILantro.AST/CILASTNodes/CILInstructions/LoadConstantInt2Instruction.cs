using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt2Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            int value = 2;
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}