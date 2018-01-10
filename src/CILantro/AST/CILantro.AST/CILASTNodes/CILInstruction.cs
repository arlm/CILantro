using CILantro.State;

namespace CILantro.AST.CILASTNodes
{
    public abstract class CILInstruction : CILASTNode
    {
        public CILMethod ParentMethod { get; set; }

        public abstract CILInstruction Execute(CILProgramState state, CILProgram program);
    }
}