using CILantro.AST.CILASTNodes;
using CILantro.AST.CILInstances;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace CILantro.AST.CILCustomTypes
{
    public class CILantroMethodInfo : MethodInfo
    {
        private CILMethod _cilMethod;

        private CILProgramInstance _programInstance;

        private CILantroType _cilantroType;

        private Type _declaringType;

        public CILMethod Method { get; set; }

        public CILantroMethodInfo(CILMethod cilMethod, CILProgramInstance programInstance, Type declaringType)
        {
            _cilMethod = cilMethod;
            _programInstance = programInstance;
            _declaringType = declaringType;
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
                return _declaringType;
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

        public override MethodBody GetMethodBody()
        {
            //return base.GetMethodBody();
            return new CILantroMethodBody();
        }

        public override CallingConventions CallingConvention
        {
            get
            {
                return base.CallingConvention;
            }
        }

        public override bool ContainsGenericParameters
        {
            get
            {
                return base.ContainsGenericParameters;
            }
        }

        public override Delegate CreateDelegate(Type delegateType)
        {
            return base.CreateDelegate(delegateType);
        }

        public override Delegate CreateDelegate(Type delegateType, object target)
        {
            return base.CreateDelegate(delegateType, target);
        }

        public override IEnumerable<CustomAttributeData> CustomAttributes
        {
            get
            {
                return base.CustomAttributes;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IList<CustomAttributeData> GetCustomAttributesData()
        {
            return base.GetCustomAttributesData();
        }

        public override Type[] GetGenericArguments()
        {
            return base.GetGenericArguments();
        }

        public override MethodInfo GetGenericMethodDefinition()
        {
            return base.GetGenericMethodDefinition();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool IsGenericMethod
        {
            get
            {
                return base.IsGenericMethod;
            }
        }

        public override bool IsGenericMethodDefinition
        {
            get
            {
                return base.IsGenericMethodDefinition;
            }
        }

        public override bool IsSecurityCritical
        {
            get
            {
                return base.IsSecurityCritical;
            }
        }

        public override bool IsSecuritySafeCritical
        {
            get
            {
                return base.IsSecuritySafeCritical;
            }
        }

        public override bool IsSecurityTransparent
        {
            get
            {
                return base.IsSecurityTransparent;
            }
        }

        public override MethodInfo MakeGenericMethod(params Type[] typeArguments)
        {
            return base.MakeGenericMethod(typeArguments);
        }

        public override MemberTypes MemberType
        {
            get
            {
                return base.MemberType;
            }
        }

        public override int MetadataToken
        {
            get
            {
                return base.MetadataToken;
            }
        }

        public override MethodImplAttributes MethodImplementationFlags
        {
            get
            {
                return base.MethodImplementationFlags;
            }
        }

        public override Module Module
        {
            get
            {
                return base.Module;
            }
        }

        public override ParameterInfo ReturnParameter
        {
            get
            {
                return new CILantroParameterInfo(Method.ReturnType, _programInstance);
                //return base.ReturnParameter;
            }
        }

        public override Type ReturnType
        {
            get
            {
                return Method.ReturnType.GetRuntimeType(_programInstance);
                //return base.ReturnType;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}