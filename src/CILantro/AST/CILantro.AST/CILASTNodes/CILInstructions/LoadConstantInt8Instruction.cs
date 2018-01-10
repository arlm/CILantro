using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt8Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            int value = 8;
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}