using CILantro.AST.CILASTNodes;
using CILantro.AST.CILInstances;
using System;
using System.Globalization;
using System.Reflection;

namespace CILantro.AST.CILCustomTypes
{
    public class CILantroFieldInfo : FieldInfo
    {
        private CILClass _cilClass;

        private string _name;

        private bool _isPublic;

        private bool _isStatic;

        public CILantroFieldInfo(CILClassField cilClassField, CILClass cilClass)
        {
            _cilClass = cilClass;

            _name = cilClassField.Name;

            _isPublic = cilClassField.IsPublic();
            _isStatic = cilClassField.IsStatic();
        }

        public override FieldAttributes Attributes
        {
            get
            {
                var result = _isPublic ? FieldAttributes.Public : FieldAttributes.Private;
                if (_isStatic) result |= FieldAttributes.Static;

                return result;
            }
        }

        public override Type DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override RuntimeFieldHandle FieldHandle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Type FieldType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name => _name;

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

        public override object GetValue(object obj)
        {
            if(_isStatic)
            {
                return _cilClass.GetStaticField(_name);
            }

            var cilClassInstance = obj as CILClassInstance;
            return cilClassInstance.GetField(_name);
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
        {
            if(_isStatic)
            {
                _cilClass.SetStaticField(_name, value);
                return;
            }

            var cilClassInstance = obj as CILClassInstance;
            cilClassInstance.SetField(_name, value);
        }
    }
}