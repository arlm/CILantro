namespace CILantro.AST.CILASTNodes
{
    public class CILMethod : CILASTNode
    {
        public bool IsEntryPoint { get; private set; }

        public CILMethod(bool isEntryPoint)
        {
            IsEntryPoint = isEntryPoint;
        }
    }
}