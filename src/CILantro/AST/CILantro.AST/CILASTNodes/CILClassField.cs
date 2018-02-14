using CILantro.AST.HelperClasses;
using CILantro.AST.HelperEnums;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.AST.CILASTNodes
{
    public class CILClassField : CILASTNode
    {
        public string Name { get; set; }

        public CILType Type { get; set; }

        public object InitValue { get; set; }

        public List<CILClassFieldAttribute> Attributes { get; set; } = new List<CILClassFieldAttribute>();

        public bool IsLiteral() => Attributes.Contains(CILClassFieldAttribute.Literal);

        public bool IsPublic() => Attributes.Contains(CILClassFieldAttribute.Public);

        public bool IsStatic() => Attributes.Contains(CILClassFieldAttribute.Static);
    }
}