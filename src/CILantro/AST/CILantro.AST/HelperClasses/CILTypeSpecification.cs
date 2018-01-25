using System;

namespace CILantro.AST.HelperClasses
{
    public class CILTypeSpecification
    {
        public CILClassName ClassName { get; set; }

        public CILType Type { get; set; }

        public Type GetTypeSpecified()
        {
            if (Type != null) return Type.GetRuntimeType();

            throw new ArgumentException("Cannot get type specified.");
        }
    }
}