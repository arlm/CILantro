using CILantro.Helpers.Convertions;
using CILantro.State;
using System;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class CallInstruction : CILInstructionMethod
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var reflectedType = TypeSpecification.GetTypeSpecified();
            var reflectedMethod = reflectedType.GetMethod(MethodName, GetMethodArgumentRuntimeTypes().ToArray());

            var methodArguments = new List<object>();
            for(int i = 0; i < MethodArgumentTypes.Count; i++)
            {
                var argumentType = GetMethodArgumentRuntimeTypes()[MethodArgumentTypes.Count - i - 1];

                var argument = state.Stack.Pop();
                var methodArgument = ConvertHelper.ConvertIfPossible(argument, argumentType);
                methodArguments.Add(methodArgument);
            }
            methodArguments.Reverse();

            object methodObject = null;
            if (CallConvention.Instance)
            {
                methodObject = state.Stack.Pop();

                if (methodObject is Guid)
                {
                    var objectAddress = (Guid)methodObject;
                    methodObject = ParentMethod.GetLocalByAddress(objectAddress);
                }
            }

            var methodResult = reflectedMethod.Invoke(methodObject, methodArguments.ToArray());
            if(MethodReturnType.GetRuntimeType() != typeof(void))
            {
                state.Stack.Push(methodResult);
            }

            return ParentMethod.GetNextInstruction(this);
        }
    }
}