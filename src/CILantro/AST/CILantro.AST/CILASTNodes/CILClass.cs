using CILantro.AST.HelperClasses;
using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes
{
    public class CILClass : CILASTNode
    {
        public CILClassName ClassName { get; set; }

        public CILClassName Extends { get; set; }

        public List<CILClassField> Fields { get; set; }

        public List<CILMethod> Methods { get; set; } = new List<CILMethod>();

        public List<CILMethod> Constructors { get; set; } = new List<CILMethod>();
    }
}