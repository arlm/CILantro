using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionSwitch : CILInstruction
    {
        public List<string> Labels { get; set; }
    }
}