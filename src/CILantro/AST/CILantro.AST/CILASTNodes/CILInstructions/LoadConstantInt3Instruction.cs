using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt3Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            int value = 3;
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}