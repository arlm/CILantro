using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantDoubleInstruction : CILInstructionR
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            state.Stack.Push(Value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}