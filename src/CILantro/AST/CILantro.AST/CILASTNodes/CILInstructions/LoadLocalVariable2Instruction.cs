using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadLocalVariable2Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var value = ParentMethod.Locals[2];
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}