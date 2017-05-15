namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadArgument0Instruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            return Method.GetNextInstruction(this);
        }
    }
}
