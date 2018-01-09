using CILantro.AST.HelperClasses;

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionTok : CILInstruction
    {
        public CILOwnerType OwnerType { get; set; }
    }
}