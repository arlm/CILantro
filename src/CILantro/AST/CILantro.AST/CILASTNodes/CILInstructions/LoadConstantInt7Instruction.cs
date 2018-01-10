using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantInt7Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            int value = 7;
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}