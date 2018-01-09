using System;
using System.Reflection;

namespace CILantro.AST.HelperClasses
{
    public class CILTypeSpecification
    {
        public CILClassName ClassName { get; set; }

        public Type GetTypeSpecified()
        {
            var assembly = Assembly.Load(ClassName.AssemblyName);
            var type = assembly.GetType(ClassName.ClassName);
            if (type != null) return type;

            throw new ArgumentException("Cannot recognize type.");
        }
    }
}