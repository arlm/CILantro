using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadFieldInstruction : CILInstructionField
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var instance = state.Stack.Pop();

            var reflectedType = FieldOwnerTypeSpecification.GetTypeSpecified();
            var reflectedField = reflectedType.GetField(FieldName);

            var value = reflectedField.GetValue(instance);
            state.Stack.Push(value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}