using CILantro.State;

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstruction : CILASTNode
    {
        public abstract CILInstruction Execute(CILProgramState state);
    }
}