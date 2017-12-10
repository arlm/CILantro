using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes
{
    public class CILMethod : CILASTNode
    {
        public List<CILInstruction> Instructions { get; private set; }

        public bool IsEntryPoint { get; private set; }

        public CILMethod(List<CILInstruction> instructions, bool isEntryPoint)
        {
            Instructions = instructions;
            IsEntryPoint = isEntryPoint;
        }
    }
}