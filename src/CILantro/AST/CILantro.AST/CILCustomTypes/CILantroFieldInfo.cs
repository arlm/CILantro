using CILantro.AST.CILInstances;
using System;
using System.Globalization;
using System.Reflection;

namespace CILantro.AST.CILCustomTypes
{
    public class CILantroFieldInfo : FieldInfo
    {
        private string _name;

        public CILantroFieldInfo(string name)
        {
            _name = name;
        }

        public override FieldAttributes Attributes
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
            var cilClassInstance = obj as CILClassInstance;
            return cilClassInstance.GetField(_name);
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
        {
            var cilClassInstance = obj as CILClassInstance;
            cilClassInstance.SetField(_name, value);
        }
    }
}