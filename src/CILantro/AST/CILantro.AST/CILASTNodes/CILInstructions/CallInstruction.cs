using CILantro.State;
using System.Collections.Generic;
using System.Reflection;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class CallInstruction : CILInstructionMethod
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var reflectedAssembly = Assembly.Load(TypeSpecification.AssemblyName);
            var reflectedClass = reflectedAssembly.GetType(TypeSpecification.ClassName);
            var reflectedMethod = reflectedClass.GetMethod(MethodName, MethodArgumentTypes.ToArray());

            var methodArguments = new List<object>();
            for(int i = 0; i < MethodArgumentTypes.Count; i++)
            {
                var argument = state.Stack.Pop();
                methodArguments.Add(argument);
            }
            methodArguments.Reverse();

            var methodResult = reflectedMethod.Invoke(null, methodArguments.ToArray());

            return ParentMethod.GetNextInstruction(this);
        }
    }
}