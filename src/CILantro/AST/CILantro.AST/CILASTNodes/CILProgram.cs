using System.Collections.Generic;
using System.Linq;

namespace CILantro.AST.CILASTNodes
{
    public class CILProgram : CILASTNode
    {
        public List<CILClass> Classes { get; private set; } = new List<CILClass>();

        public CILMethod EntryPoint => Classes.SelectMany(c => c.Methods).SingleOrDefault(m => m.IsEntryPoint);

        public CILProgram(List<CILClass> classes)
        {
            Classes = classes;
        }
    }
}