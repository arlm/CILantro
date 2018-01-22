using CILantro.Reflection;
using System;

namespace CILantro.AST.HelperClasses
{
    public class CILTypeSpecification
    {
        public CILClassName ClassName { get; set; }

        public CILType Type { get; set; }

        public Type GetTypeSpecified()
        {
            if(ClassName != null) return RuntimeTypeManager.GetRuntimeType(ClassName.ClassName, ClassName.AssemblyName);
            if (Type != null) return Type.GetRuntimeType();

            throw new ArgumentException("Cannot get type specified.");
        }
    }
}