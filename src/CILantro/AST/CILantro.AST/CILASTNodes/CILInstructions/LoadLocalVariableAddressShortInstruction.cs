using CILantro.State;

namespace CILantro.AST.CILASTNodes.CILInstructions
{
    public class LoadLocalVariableAddressShortInstruction : CILInstructionVar
    {
        public override CILInstruction Execute(CILProgramState state, CILProgram program)
        {
            var localAddress = ParentMethod.GetLocalAddress(VariableId);
            state.Stack.Push(localAddress);

            return ParentMethod.GetNextInstruction(this);
        }
    }
}