using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class MultiplyInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var val2 = (int)state.Stack.Pop();
            var val1 = (int)state.Stack.Pop();
            var result = val1 * val2;
            state.Stack.Push(result);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}