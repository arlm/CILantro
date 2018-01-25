using CILantro.AST.HelperClasses;

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionField : CILInstruction
    {
        public CILType FieldType { get; set; }

        public CILTypeSpecification FieldOwnerTypeSpecification { get; set; }

        public string FieldName { get; set; }
    }
}