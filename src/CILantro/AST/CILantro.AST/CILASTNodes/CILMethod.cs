using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes
{
    public class CILMethod : CILASTNode
    {
        public List<CILInstruction> Instructions { get; set; }

        public bool IsEntryPoint { get; set; }

        public CILInstruction GetNextInstruction(CILInstruction currentInstruction)
        {
            var currentIndex = Instructions.IndexOf(currentInstruction);
            var nextIndex = currentIndex + 1;

            if (nextIndex >= Instructions.Count) return null;
            return Instructions[nextIndex];
        }
    }
}