using CILantro.AST.HelperClasses;
using System;
using System.Reflection;

namespace CILantro.AST.CILCustomTypes
{
    public class CILantroParameterInfo : ParameterInfo
    {
        private CILType _cilType;

        public CILantroParameterInfo(CILType cilType)
        {
            _cilType = cilType;
        }

        public override Type ParameterType => _cilType.SimpleType;
    }
}