using CILantro.AST.CILInstances;
using CILantro.State;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class CallVirtualInstruction : CILInstructionMethod
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var reflectedAssembly = Assembly.Load(TypeSpecification.ClassName.AssemblyName);
            var reflectedClass = reflectedAssembly.GetType(TypeSpecification.ClassName.ClassName);
            var reflectedMethod = reflectedClass.GetMethod(MethodName, GetMethodArgumentRuntimeTypes(programInstance).ToArray());

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
            if (MethodReturnType.GetRuntimeType(programInstance) != typeof(void))
            {
                state.Stack.Push(methodResult);
            }

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}