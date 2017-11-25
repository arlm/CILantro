using CILantro.Helpers;

namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfEqualShortInstruction : InstructionBranch
    {
        public override int BytesLength => 2;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value1 = state.Stack.Pop();
            var value2 = state.Stack.Pop();

            if (value1.EqualsWithoutTypeChecking(value2)) return Method.GetInstructionByBranchTarget(this, Target, TargetLabel);
            return Method.GetNextInstruction(this);
        }
    }
}