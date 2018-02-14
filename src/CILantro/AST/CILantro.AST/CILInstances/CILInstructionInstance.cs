using CILantro.AST.CILASTNodes;
using CILantro.State;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILInstances
{
    public class CILInstructionInstance
    {
        public CILInstruction Instruction { get; private set; }

        public CILMethodInstance MethodInstance { get; private set; }

        public CILInstructionInstance(CILInstruction instruction, CILMethodInstance methodInstance)
        {
            Instruction = instruction;
            MethodInstance = methodInstance;
        }

        public CILInstructionInstance Execute(CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            return Instruction.Execute(this, state, programInstance, callStack);
        }

        public CILInstructionInstance GetNextInstructionInstance()
        {
            return MethodInstance.Method.GetNextInstruction(Instruction).CreateInstance(MethodInstance);
        }

        public CILInstructionInstance GetInstructionInstanceByBranchTarget(string label)
        {
            return MethodInstance.Method.GetInstructionByBranchTarget(label).CreateInstance(MethodInstance);
        }
    }
}