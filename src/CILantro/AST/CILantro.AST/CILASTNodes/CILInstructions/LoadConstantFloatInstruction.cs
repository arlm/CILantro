using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantFloatInstruction : CILInstructionR
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            state.Stack.Push(Value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}