using CILantro.AST.CILCustomTypes;
using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class NewObjectInstruction : CILInstructionMethod
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var reflectedType = TypeSpecification.GetTypeSpecified(programInstance);
            var reflectedConstructor = reflectedType.GetConstructor(GetMethodArgumentRuntimeTypes(programInstance).ToArray());

            var methodArguments = new List<object>();
            for (int i = 0; i < MethodArgumentTypes.Count; i++)
            {
                var argument = state.Stack.Pop();
                var methodArgument = argument;
                try
                {
                    methodArgument = Convert.ChangeType(argument, GetMethodArgumentRuntimeTypes(programInstance)[MethodArgumentTypes.Count - i - 1]);
                }
                catch (Exception) { }
                methodArguments.Add(methodArgument);
            }
            methodArguments.Reverse();

            if (reflectedConstructor is CILantroConstructorInfo)
            {
                callStack.Push(instructionInstance.GetNextInstructionInstance());

                var cilantroConstructor = reflectedConstructor as CILantroConstructorInfo;
                return cilantroConstructor.Method.CreateInstance(methodArguments.ToArray()).GetFirstInstructionInstance();
            }

            var methodResult = reflectedConstructor.Invoke(methodArguments.ToArray());
            state.Stack.Push(methodResult);

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}