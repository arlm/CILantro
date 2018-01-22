using CILantro.State;
using System;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class NewObjectInstruction : CILInstructionMethod
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var reflectedType = TypeSpecification.GetTypeSpecified();
            var reflectedConstructor = reflectedType.GetConstructor(GetMethodArgumentRuntimeTypes().ToArray());

            var methodArguments = new List<object>();
            for (int i = 0; i < MethodArgumentTypes.Count; i++)
            {
                var argument = state.Stack.Pop();
                var methodArgument = argument;
                try
                {
                    methodArgument = Convert.ChangeType(argument, GetMethodArgumentRuntimeTypes()[MethodArgumentTypes.Count - i - 1]);
                }
                catch (Exception) { }
                methodArguments.Add(methodArgument);
            }
            methodArguments.Reverse();

            var methodResult = reflectedConstructor.Invoke(methodArguments.ToArray());
            state.Stack.Push(methodResult);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}