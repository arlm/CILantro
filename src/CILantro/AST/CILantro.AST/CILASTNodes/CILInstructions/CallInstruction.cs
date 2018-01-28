﻿using CILantro.AST.CILInstances;
using CILantro.Helpers.Convertions;
using CILantro.State;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class CallInstruction : CILInstructionMethod
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var reflectedType = TypeSpecification.GetTypeSpecified(programInstance);
            var reflectedMethod = (MethodBase)reflectedType.GetMethod(MethodName, GetMethodArgumentRuntimeTypes(programInstance).ToArray());
            if(reflectedMethod == null && MethodName.Equals(".ctor") && ParentMethod.IsConstructor)
            {
                return instructionInstance.GetNextInstructionInstance();
            }

            var methodArguments = new List<object>();
            for(int i = 0; i < MethodArgumentTypes.Count; i++)
            {
                var argumentType = GetMethodArgumentRuntimeTypes(programInstance)[MethodArgumentTypes.Count - i - 1];

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
            if(MethodReturnType.GetRuntimeType(programInstance) != typeof(void))
            {
                state.Stack.Push(methodResult);
            }

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}