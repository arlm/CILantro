using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadStringInstruction : CILInstructionString
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            state.Stack.Push(StringValue);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}