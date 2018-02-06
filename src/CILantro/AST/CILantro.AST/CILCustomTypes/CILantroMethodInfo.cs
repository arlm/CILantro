using CILantro.AST.CILASTNodes;
using CILantro.AST.CILInstances;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace CILantro.AST.CILCustomTypes
{
    public class CILantroMethodInfo : MethodInfo
    {
        private CILMethod _cilMethod;

        private CILProgramInstance _programInstance;

        public CILMethod Method { get; set; }

        public CILantroMethodInfo(CILMethod cilMethod, CILProgramInstance programInstance)
        {
            _cilMethod = cilMethod;
            _programInstance = programInstance;
            Method = cilMethod;
        }

        public override MethodAttributes Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Type DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override RuntimeMethodHandle MethodHandle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name => _cilMethod.MethodName;

        public override Type ReflectedType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ICustomAttributeProvider ReturnTypeCustomAttributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override MethodInfo GetBaseDefinition()
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override MethodImplAttributes GetMethodImplementationFlags()
        {
            throw new NotImplementedException();
        }

        public override ParameterInfo[] GetParameters()
        {
            return _cilMethod.ArgumentTypes.Select(at => new CILantroParameterInfo(at, _programInstance)).ToArray();
        }

        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }
    }
}