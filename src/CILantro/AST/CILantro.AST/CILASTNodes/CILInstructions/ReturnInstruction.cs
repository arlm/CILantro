using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class ReturnInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            return null;
        }
    }
}