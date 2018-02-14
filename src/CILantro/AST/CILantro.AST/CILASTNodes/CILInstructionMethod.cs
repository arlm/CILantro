using CILantro.AST.CILInstances;
using CILantro.AST.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstructionMethod : CILInstruction
    {
        public CILTypeSpecification TypeSpecification { get; set; }

        public string MethodName { get; set; }

        public List<CILType> MethodArgumentTypes { get; set; } = new List<CILType>();

        public CILType MethodReturnType { get; set; }

        public CILCallConvention CallConvention { get; set; }

        public List<Type> GetMethodArgumentRuntimeTypes(CILProgramInstance programInstance)
        {
            return MethodArgumentTypes.Select(at => at.GetRuntimeType(programInstance)).ToList();
        }
    }
}