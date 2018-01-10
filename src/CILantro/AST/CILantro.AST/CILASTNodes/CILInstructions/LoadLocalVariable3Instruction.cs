using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadLocalVariable3Instruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = ParentMethod.Locals[3];
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}