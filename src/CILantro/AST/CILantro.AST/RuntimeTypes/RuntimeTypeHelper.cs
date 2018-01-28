using CILantro.AST.HelperClasses;
using System;
using System.Reflection;

namespace CILantro.AST.RuntimeTypes
{
    public static class RuntimeTypeHelper
    {
        public static Type GetRuntimeType(CILClassName className)
        {
            var reflectedAssembly = Assembly.Load(className.AssemblyName);
            var reflectedType = reflectedAssembly.GetType(className.ClassName);
            return reflectedType;
        }
    }
}