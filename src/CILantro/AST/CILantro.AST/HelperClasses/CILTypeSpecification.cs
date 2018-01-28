using CILantro.AST.CILInstances;
using System;
using System.Reflection;

namespace CILantro.AST.HelperClasses
{
    public class CILTypeSpecification
    {
        public CILClassName ClassName { get; set; }

        public CILType Type { get; set; }

        public Type GetTypeSpecified(CILProgramInstance programInstance)
        {
            if (Type != null) return Type.GetRuntimeType(programInstance);

            if(ClassName != null)
            {
                var customType = programInstance.GetCustomType(ClassName);
                if (customType != null) return customType;

                var reflectedAssembly = Assembly.Load(ClassName.AssemblyName);
                return reflectedAssembly.GetType(ClassName.ClassName);
            }

            throw new ArgumentException("Cannot get type specified.");
        }
    }
}