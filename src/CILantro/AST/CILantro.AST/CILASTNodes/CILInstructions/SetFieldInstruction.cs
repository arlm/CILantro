using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class SetFieldInstruction : CILInstructionField
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var value = state.Stack.Pop();
            var instance = state.Stack.Pop();

            var reflectedType = FieldOwnerTypeSpecification.GetTypeSpecified();
            var reflectedField = reflectedType.GetField(FieldName);

            reflectedField.SetValue(instance, value);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}