using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class BranchShortInstruction : CILInstructionBranchTarget
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            return ParentMethod.GetInstructionByBranchTarget(Label);
        }
    }
}