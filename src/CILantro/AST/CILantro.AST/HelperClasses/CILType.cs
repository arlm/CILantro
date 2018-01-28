using CILantro.AST.CILInstances;
using System;
using System.Reflection;

namespace CILantro.AST.HelperClasses
{
    public class CILType
    {
        public CILClassName ClassName { get; set; }

        public Type SimpleType { get; set; }

        public Type GetRuntimeType(CILProgramInstance programInstance)
        {
            if (SimpleType != null) return SimpleType;

            if (ClassName != null)
            {
                var customType = programInstance.GetCustomType(ClassName);
                if (customType != null) return customType;

                var reflectedAssembly = Assembly.Load(ClassName.AssemblyName);
                return reflectedAssembly.GetType(ClassName.ClassName);
            }

            throw new NotImplementedException("Complex types are not supported yet.");
        }
    }
}