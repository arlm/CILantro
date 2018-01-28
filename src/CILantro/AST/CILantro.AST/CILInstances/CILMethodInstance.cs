using CILantro.AST.CILASTNodes;
using System.Linq;

namespace CILantro.AST.CILInstances
{
    public class CILMethodInstance
    {
        public CILMethod Method { get; private set; }

        public CILClassInstance This { get; private set; }

        public CILMethodInstance(CILMethod method, CILClassInstance thisInstance)
        {
            Method = method;
            This = thisInstance;
        }

        public CILInstructionInstance GetFirstInstructionInstance()
        {
            return Method.Instructions.First().CreateInstance(this);
        }
    }
}