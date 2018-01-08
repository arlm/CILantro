using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadConstantIntShortInstruction : CILInstructionI
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            state.Stack.Push(Value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}