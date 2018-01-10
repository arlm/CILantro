using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SetLocalVariable2Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = state.Stack.Pop();
            ParentMethod.Locals[2] = value;

            return ParentMethod.GetNextInstruction(this);
        }
    }
}