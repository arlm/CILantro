using CILantro.Reflection;
using System;

namespace CILantro.AST.HelperClasses
{
    public class CILTypeSpecification
    {
        public CILClassName ClassName { get; set; }

        public Type GetTypeSpecified()
        {
            return RuntimeTypeManager.GetRuntimeType(ClassName.ClassName, ClassName.AssemblyName);
        }
    }
}