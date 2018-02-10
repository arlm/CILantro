using CILantro.AST.CILASTNodes;
using System.Collections.Generic;

namespace CILantro.AST.CILInstances
{
    public class CILClassInstance
    {
        public CILClass _cilClass;

        public Dictionary<string, object> Fields { get; set; }

        public CILClassInstance(CILClass cilClass)
        {
            _cilClass = cilClass;

            Fields = new Dictionary<string, object>();
            foreach(var cilField in cilClass.Fields)
            {
                if(!cilField.IsStatic()) Fields.Add(cilField.Name, null);
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
    }
}