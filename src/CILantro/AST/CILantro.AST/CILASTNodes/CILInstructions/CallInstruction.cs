using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class CallInstruction : CILInstructionMethod
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            return ParentMethod.GetNextInstruction(this);
        }
    }
}