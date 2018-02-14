// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionBranchTarget : CILInstruction
    {
        public string Label { get; set; }
    }
}