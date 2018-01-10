using System.Collections.Generic;
using System.Linq;

namespace CILantro.AST.CILASTNodes
{
    public class CILProgram : CILASTNode
    {
        public List<CILAssembly> Assemblies { get; set; }

        public List<CILExternalAssembly> ExternalAssemblies { get; set; }

        public List<CILModule> Modules { get; set; }

        public List<CILClass> Classes { get; set; } = new List<CILClass>();

        public CILMethod EntryPoint => Classes.SelectMany(c => c.Methods).SingleOrDefault(m => m.IsEntryPoint);
    }
}