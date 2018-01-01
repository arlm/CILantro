using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadLocalVariable0Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var value = ParentMethod.Locals[0];
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}