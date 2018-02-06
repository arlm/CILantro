using CILantro.AST.CILInstances;
using CILantro.AST.HelperClasses;
using System;
using System.Reflection;

namespace CILantro.AST.CILCustomTypes
{
    public class CILantroParameterInfo : ParameterInfo
    {
        private CILType _cilType;

        private CILProgramInstance _programInstance;

        public CILantroParameterInfo(CILType cilType, CILProgramInstance programInstance)
        {
            _cilType = cilType;
            _programInstance = programInstance;
        }

        public override Type ParameterType
        {
            get
            {
                if(_cilType.SimpleType != null) return _cilType.SimpleType;
                return _cilType.GetRuntimeType(_programInstance);
            }
        }
    }
}