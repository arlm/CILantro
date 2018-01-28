using CILantro.AST.CILCustomTypes;
using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class UnboxAnyInstruction : CILInstructionType
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var value = state.Stack.Pop();

            var newType = TypeSpecification.GetTypeSpecified(programInstance);
            if (newType is CILantroType) newType = (newType as CILantroType).GetRuntimeType();
            var newValue = Convert.ChangeType(value, newType);

            state.Stack.Push(newValue);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}