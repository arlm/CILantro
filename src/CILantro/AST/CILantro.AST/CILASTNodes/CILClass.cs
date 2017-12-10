using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes
{
    public class CILClass : CILASTNode
    {
        public List<CILMethod> Methods { get; set; } = new List<CILMethod>();
    }
}