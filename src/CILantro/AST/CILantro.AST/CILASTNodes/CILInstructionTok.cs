using CILantro.AST.HelperClasses;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionTok : CILInstruction
    {
        public CILOwnerType OwnerType { get; set; }
    }
}