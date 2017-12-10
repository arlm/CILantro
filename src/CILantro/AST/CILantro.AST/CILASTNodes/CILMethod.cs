namespace CILantro.AST.CILASTNodes
{
    public class CILMethod : CILASTNode
    {
        public bool IsEntrypoint { get; private set; }

        public CILMethod(bool isEntrypoint)
        {
            IsEntrypoint = isEntrypoint;
        }
    }
}