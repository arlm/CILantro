using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadLocalVariableShortInstruction : CILInstructionVar
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = ParentMethod.Locals[VariableId];
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}