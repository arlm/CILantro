using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstruction : CILASTNode
    {
        public CILMethod ParentMethod { get; set; }

        public abstract CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack);

        public CILInstructionInstance CreateInstance(CILMethodInstance methodInstance)
        {
            return new CILInstructionInstance(this, methodInstance);
        }
    }
}