using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadLocalVariable1Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var value = ParentMethod.Locals[1];
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}