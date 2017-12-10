using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes
{
    public class CILClass : CILASTNode
    {
        public List<CILMethod> Methods { get; private set; } = new List<CILMethod>();

        public CILClass(List<CILMethod> methods)
        {
            Methods = methods;
        }
    }
}