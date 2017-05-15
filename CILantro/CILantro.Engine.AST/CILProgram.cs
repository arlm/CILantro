using CILantro.Engine.AST.ASTNodes;
using System.Linq;

namespace CILantro.Engine.AST
{
    public class CILProgram : CILASTNode
    {
        public CILClass Class { get; set; }

        public CILMethod EntryPoint
        {
            get
            {
                return Class.Methods.SingleOrDefault(m => m.IsEntryPoint);
            }
        }
    }
}
