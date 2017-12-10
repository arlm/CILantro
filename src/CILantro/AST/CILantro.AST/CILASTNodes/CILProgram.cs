using System.Collections.Generic;

namespace CILantro.AST.CILASTNodes
{
    public class CILProgram : CILASTNode
    {
        public List<CILClass> Classes { get; private set; } = new List<CILClass>();

        public CILProgram(List<CILClass> classes)
        {
            Classes = classes;
        }
    }
}