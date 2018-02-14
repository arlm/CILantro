using CILantro.AST.HelperClasses;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionType : CILInstruction
    {
        public CILTypeSpecification TypeSpecification { get; set; }
    }
}