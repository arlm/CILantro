using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionSwitch : CILInstruction
    {
        public List<string> Labels { get; set; }
    }
}