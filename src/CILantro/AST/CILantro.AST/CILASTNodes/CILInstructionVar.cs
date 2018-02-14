// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionVar : CILInstruction
    {
        public string VariableId { get; set; }
    }
}