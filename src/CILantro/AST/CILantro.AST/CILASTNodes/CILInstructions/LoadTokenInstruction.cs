using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadTokenInstruction : CILInstructionTok
    {
        public override CILInstruction Execute(CILProgramState state)
        {
            var typeSpecified = OwnerType.TypeSpecification.GetTypeSpecified();
            var typeHandle = typeSpecified.TypeHandle;
            state.Stack.Push(typeHandle);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}