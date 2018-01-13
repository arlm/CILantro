using CILantro.AST.HelperClasses;

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionType : CILInstruction
    {
        public CILTypeSpecification TypeSpecification { get; set; }
    }
}