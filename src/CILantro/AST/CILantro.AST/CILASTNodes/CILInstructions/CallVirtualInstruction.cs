using CILantro.AST.CILCustomTypes;
using CILantro.AST.CILInstances;
using CILantro.Helpers.Convertions;
using CILantro.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class CallVirtualInstruction : CILInstructionMethod
    {
        public override CILInstructionInstance Execute(CILInstructionInstance instructionInstance, CILProgramState state, CILProgramInstance programInstance, Stack<CILInstructionInstance> callStack)
        {
            var reflectedType = TypeSpecification.GetTypeSpecified(programInstance);
            var reflectedMethod = (MethodBase)reflectedType.GetMethod(MethodName, GetMethodArgumentRuntimeTypes(programInstance).ToArray());
            if (reflectedMethod == null && MethodName.Equals(".ctor") && ParentMethod.IsConstructor)
            {
                return instructionInstance.GetNextInstructionInstance();
            }

            var methodArguments = new List<object>();
            for (int i = 0; i < MethodArgumentTypes.Count; i++)
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

            var methodObjectToCall = methodObject;
            if (methodObjectToCall is CILClassInstance) methodObjectToCall = (methodObjectToCall as CILClassInstance).BaseInstance;

            if(methodObject is CILClassInstance)
            {
                var cilClass = (methodObject as CILClassInstance)._cilClass;
                var cilMethod = cilClass.Methods.SingleOrDefault(m => m.MethodName == this.MethodName && CILantroType.CompareArgumentTypes(m.ArgumentTypes.Select(at => at.GetRuntimeType(programInstance)).ToArray(), this.GetMethodArgumentRuntimeTypes(programInstance).ToArray()));
                while(cilClass != null && cilMethod == null)
                {
                    cilClass = cilClass.ExtendsClass;
                    if(cilClass != null)
                        cilMethod = cilClass.Methods.SingleOrDefault(m => m.MethodName == this.MethodName && CILantroType.CompareArgumentTypes(m.ArgumentTypes.Select(at => at.GetRuntimeType(programInstance)).ToArray(), this.GetMethodArgumentRuntimeTypes(programInstance).ToArray()));
                }

                if(cilMethod != null)
                {
                    var newMethodInfo = new CILantroMethodInfo(cilMethod, programInstance, cilMethod.ReturnType.GetRuntimeType(programInstance));
                    reflectedMethod = newMethodInfo;
                }
            }

            if (reflectedMethod is CILantroMethodInfo)
            {
                callStack.Push(instructionInstance.GetNextInstructionInstance());

                var cilantroMethodInfo = reflectedMethod as CILantroMethodInfo;
                CILMethod methodToCall = null;

                object obj = methodObject;
                //object obj = null;
                if (CallConvention.Instance)
                {
                    //obj = state.Stack.Pop();
                    var cilClassInstance = obj as CILClassInstance;
                    var cilClass = cilClassInstance._cilClass;

                    while (cilClass != null)
                    {
                        var matchingMethod = cilClass.Methods.FirstOrDefault(m => m.MethodName.Equals(MethodName) && CILantroType.CompareArgumentTypes(GetMethodArgumentRuntimeTypes(programInstance).ToArray(), m.ArgumentTypes.Select(ct => ct.GetRuntimeType(programInstance)).ToArray()));
                        if (matchingMethod != null)
                        {
                            methodToCall = matchingMethod;
                            break;
                        }

                        cilClass = programInstance.Program.Classes.FirstOrDefault(c => c.ClassName.UniqueName == cilClass.Extends.UniqueName);
                    }
                }

                if (methodToCall == null) methodToCall = cilantroMethodInfo.Method;

                return methodToCall.CreateInstance(obj, methodArguments.ToArray()).GetFirstInstructionInstance();
            }

            var methodResult = reflectedMethod.Invoke(methodObjectToCall, methodArguments.ToArray());
            if (MethodReturnType.GetRuntimeType(programInstance) != typeof(void))
            {
                state.Stack.Push(methodResult);
            }

            return instructionInstance.GetNextInstructionInstance();
        }
    }
}