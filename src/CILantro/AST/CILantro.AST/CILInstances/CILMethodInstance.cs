using CILantro.AST.CILASTNodes;
using System.Linq;

namespace CILantro.AST.CILInstances
{
    public class CILMethodInstance
    {
        public CILMethod Method { get; private set; }

        public CILClassInstance This { get; private set; }

        public object[] Arguments { get; private set; }

        public CILMethodInstance(CILMethod method, CILClassInstance thisInstance, object[] arguments)
        {
            Method = method;
            This = thisInstance;
            Arguments = arguments;
        }

        public CILInstructionInstance GetFirstInstructionInstance()
        {
            return Method.Instructions.First().CreateInstance(this);
        }
    }
}