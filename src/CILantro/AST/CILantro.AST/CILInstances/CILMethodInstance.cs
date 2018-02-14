using CILantro.AST.CILASTNodes;
using System.Collections.Specialized;
using System.Linq;

// TODO - REFAKTORING

namespace CILantro.AST.CILInstances
{
    public class CILMethodInstance
    {
        public CILMethod Method { get; private set; }

        public CILClassInstance This { get; private set; }

        public OrderedDictionary Arguments { get; private set; }

        public CILMethodInstance(CILMethod method, CILClassInstance thisInstance, OrderedDictionary arguments)
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