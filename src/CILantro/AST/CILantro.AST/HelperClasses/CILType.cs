using CILantro.Reflection;
using System;

namespace CILantro.AST.HelperClasses
{
    public class CILType
    {
        public CILClassName ClassName { get; set; }

        public Type SimpleType { get; set; }

        public Type GetRuntimeType()
        {
            if (SimpleType != null) return SimpleType;

            return RuntimeTypeManager.GetRuntimeType(ClassName.ClassName, ClassName.AssemblyName);
        }
    }
}