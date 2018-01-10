using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class NotInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = (int)state.Stack.Pop();

            var result = ~value;
            state.Stack.Push(result);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}