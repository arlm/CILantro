using CILantro.AST.CILASTNodes;
using CILantro.AST.CILCustomTypes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

// TODO - REFAKTORING

namespace CILantro.AST.CILInstances
{
    public class CILClassInstance
    {
        public CILClass _cilClass;

        public object BaseInstance { get; set; }

        public Dictionary<string, object> Fields { get; set; }

        public Dictionary<string, Guid> FieldAddresses { get; set; }

        public CILClassInstance(CILClass cilClass)
        {
            _cilClass = cilClass;

            Fields = new Dictionary<string, object>();
            FieldAddresses = new Dictionary<string, Guid>();
            foreach (var cilField in cilClass.Fields)
            {
                if(!cilField.IsStatic()) Fields.Add(cilField.Name, null);
                if (!cilField.IsStatic()) FieldAddresses.Add(cilField.Name, Guid.NewGuid());
            }

            var baseClass = _cilClass;
            var nextBaseClass = baseClass.ExtendsClass;
            while (nextBaseClass != null)
            {
                baseClass = nextBaseClass;
                nextBaseClass = baseClass.ExtendsClass;
            }
            
            var extendsAssembly = Assembly.Load(baseClass.Extends.AssemblyName);
            var extendsType = extendsAssembly.GetType(baseClass.Extends.ClassName);
            if(extendsType.IsAbstract)
            {
                BaseInstance = FormatterServices.GetUninitializedObject(baseClass.RuntimeType);
            }
            else
            {
                BaseInstance = FormatterServices.GetUninitializedObject(extendsType);
            }
        }

        public void SetField(string fieldName, object value)
        {
            Fields[fieldName] = value;
        }

        public object GetField(string fieldName)
        {
            return Fields[fieldName];
        }

        public Guid GetFieldAddress(string fieldName)
        {
            return FieldAddresses[fieldName];
        }

        public new Type GetType()
        {
            return new CILantroType(this._cilClass, null);
        }
    }
}