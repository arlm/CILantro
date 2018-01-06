using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SetLocalVariable1Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var value = state.Stack.Pop();
            ParentMethod.Locals[1] = value;

            return ParentMethod.GetNextInstruction(this);
        }
    }
}