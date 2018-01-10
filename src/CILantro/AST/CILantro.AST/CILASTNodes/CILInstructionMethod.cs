using CILantro.AST.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionMethod : CILInstruction
    {
        public CILTypeSpecification TypeSpecification { get; set; }

        public string MethodName { get; set; }

        public List<CILType> MethodArgumentTypes { get; set; } = new List<CILType>();

        public CILType MethodReturnType { get; set; }

        public CILCallConvention CallConvention { get; set; }

        public List<Type> GetMethodArgumentRuntimeTypes()
        {
            return MethodArgumentTypes.Select(at => at.GetRuntimeType()).ToList();
        }
    }
}