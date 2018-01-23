using CILantro.Helpers.Convertions;
using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class ConvertToUnsignedLongInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = state.Stack.Pop();

            var result = ConvertHelper.ToUnsignedLong(value);
            state.Stack.Push(result);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}