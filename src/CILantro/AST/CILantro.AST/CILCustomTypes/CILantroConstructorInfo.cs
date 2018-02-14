using CILantro.AST.CILASTNodes;
using CILantro.AST.CILInstances;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

// TODO - REFAKTORING

namespace CILantro.AST.CILCustomTypes
{
    public class CILantroConstructorInfo : ConstructorInfo
    {
        private CILProgramInstance _programInstance;

        public CILMethod Method { get; private set; }

        public CILantroConstructorInfo(CILMethod cilMethod, CILProgramInstance programInstance)
        {
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

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Type ReflectedType
        {
            get
            {
                throw new NotImplementedException();
            }
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
            return Method.ArgumentTypes.Select(at => new CILantroParameterInfo(at, _programInstance)).ToArray();
        }

        public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            throw new NotImplementedException();
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