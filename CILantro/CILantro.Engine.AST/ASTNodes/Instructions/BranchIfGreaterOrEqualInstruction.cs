namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfGreaterOrEqualInstruction : InstructionBranch
    {
        public override int BytesLength => 5;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value2 = (int)state.Stack.Pop();
            var value1 = (int)state.Stack.Pop();

            if (value1 >= value2) return Method.GetInstructionByBranchTarget(this, Target, TargetLabel);
            return Method.GetNextInstruction(this);
        }
    }
}