using CILantro.AST.HelperClasses;
using System;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionMethod : CILInstruction
    {
        public CILTypeSpecification TypeSpecification { get; set; }

        public string MethodName { get; set; }

        public List<Type> MethodArgumentTypes { get; set; } = new List<Type>();

        public Type MethodReturnType { get; set; }

        public CILCallConvention CallConvention { get; set; }
    }
}