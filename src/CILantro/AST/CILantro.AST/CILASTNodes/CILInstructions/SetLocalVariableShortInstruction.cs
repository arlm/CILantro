using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SetLocalVariableShortInstruction : CILInstructionVar
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var value = state.Stack.Pop();
            ParentMethod.Locals[VariableId] = value;

            return ParentMethod.GetNextInstruction(this);
        }
    }
}