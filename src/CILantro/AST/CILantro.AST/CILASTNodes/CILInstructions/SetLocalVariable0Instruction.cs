using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SetLocalVariable0Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = state.Stack.Pop();
            ParentMethod.Locals[0] = value;

            return ParentMethod.GetNextInstruction(this);
        }
    }
}