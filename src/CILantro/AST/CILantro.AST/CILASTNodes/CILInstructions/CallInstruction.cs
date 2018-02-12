using CILantro.AST.CILCustomTypes;
using CILantro.AST.CILInstances;
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
            if(reflectedMethod == null && MethodName.Equals(".ctor"))
            {
                var reflectedConstructor = reflectedType.GetConstructor(GetMethodArgumentRuntimeTypes(programInstance).ToArray());
                if (reflectedConstructor == null)
                    reflectedConstructor = reflectedType.GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, GetMethodArgumentRuntimeTypes(programInstance).ToArray(), null);
                reflectedMethod = (MethodBase)reflectedConstructor;
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

            if(reflectedMethod is CILantroMethodInfo)
            {
                callStack.Push(instructionInstance.GetNextInstructionInstance());

                object obj = null;
                if(CallConvention.Instance)
                {
                    obj = state.Stack.Pop();
                }

                var cilantroMethod = reflectedMethod as CILantroMethodInfo;
                return cilantroMethod.Method.CreateInstance(obj, methodArguments.ToArray()).GetFirstInstructionInstance();
            }

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

            var methodObjectToCall = methodObject;
            if (methodObjectToCall is CILClassInstance) methodObjectToCall = (methodObjectToCall as CILClassInstance).BaseInstance;

            var methodResult = reflectedMethod.Invoke(methodObjectToCall, methodArguments.ToArray());
            if(MethodReturnType.GetRuntimeType(programInstance) != typeof(void))
            {
                state.Stack.Push(methodResult);
            }
            else if(MethodName.Equals(".ctor"))
            {
                state.Stack.Push(methodObject);
            }

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}