using CILantro.AST.CILASTNodes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace CILantro.AST.CILCustomTypes
{
    public class CILantroType : Type
    {
        private CILClass _cilClass;

        private Type _runtimeType;

        private List<CILantroFieldInfo> _fields;

        private List<CILantroConstructorInfo> _constructors;

        private List<CILantroMethodInfo> _methods;

        public CILantroType(CILClass cilClass, Type runtimeType)
        {
            _cilClass = cilClass;
            _runtimeType = runtimeType;

            _fields = _cilClass.Fields.Select(f => new CILantroFieldInfo(f, cilClass)).ToList();
            _constructors = _cilClass.Constructors.Select(c => new CILantroConstructorInfo(c)).ToList();
            _methods = _cilClass.Methods.Select(m => new CILantroMethodInfo(m)).ToList();
        }

        public Type GetRuntimeType()
        {
            return _runtimeType;
        }

        public override Assembly Assembly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string AssemblyQualifiedName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Type BaseType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string FullName
        {
            get
            {
                return Name;
            }
        }

        public override Guid GUID
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Module Module
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name => $"[CILantroType] {_cilClass.ClassName.ClassName}";

        public override string Namespace
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Type UnderlyingSystemType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
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

        public override Type GetElementType()
        {
            throw new NotImplementedException();
        }

        public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override EventInfo[] GetEvents(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override FieldInfo GetField(string name, BindingFlags bindingAttr)
        {
            if (bindingAttr.HasFlag(BindingFlags.Static))
                return _fields.Where(f => f.IsStatic).SingleOrDefault(f => f.Name == name);

            return _fields.Where(f => !f.IsStatic).SingleOrDefault(f => f.Name == name);
        }

        public override FieldInfo[] GetFields(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type GetInterface(string name, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetInterfaces()
        {
            throw new NotImplementedException();
        }

        public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type GetNestedType(string name, BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override Type[] GetNestedTypes(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
        {
            throw new NotImplementedException();
        }

        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
        {
            throw new NotImplementedException();
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        protected override TypeAttributes GetAttributeFlagsImpl()
        {
            throw new NotImplementedException();
        }

        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
            return _constructors.Single(c => CompareArgumentTypes(types, c.GetParameters().Select(p => p.ParameterType).ToArray()));
        }

        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
            return _methods.Single(m => m.Name == name && CompareArgumentTypes(types, m.GetParameters().Select(p => p.ParameterType).ToArray()));
        }

        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
        {
            throw new NotImplementedException();
        }

        protected override bool HasElementTypeImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsArrayImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsByRefImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsCOMObjectImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPointerImpl()
        {
            throw new NotImplementedException();
        }

        protected override bool IsPrimitiveImpl()
        {
            throw new NotImplementedException();
        }

        public override RuntimeTypeHandle TypeHandle
        {
            get
            {
                return _runtimeType.TypeHandle;
            }
        }

        private bool CompareArgumentTypes(Type[] args1, Type[] args2)
        {
            if (args1.Length != args2.Length) return false;

            for(int i = 0; i < args1.Length; i++)
            {
                if (args1[i] != args2[i]) return false;
            }

            return true;
        }
    }
}