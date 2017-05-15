using System.Collections.Generic;

namespace CILantro.Engine.AST.ASTNodes
{
    public class CILClass : CILASTNode
    {
        public List<CILMethod> Methods { get; set; }
    }
}
