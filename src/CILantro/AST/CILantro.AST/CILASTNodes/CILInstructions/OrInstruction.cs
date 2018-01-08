using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class OrInstruction : CILInstructionNone
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var value2 = state.Stack.Pop();
            var value1 = state.Stack.Pop();

            object result = null;
            if (value1 is bool && value2 is bool) result = (bool)value1 | (bool)value2;
            if (value1 is int && value2 is int) result = (int)value1 | (int)value2;

            state.Stack.Push(result);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}