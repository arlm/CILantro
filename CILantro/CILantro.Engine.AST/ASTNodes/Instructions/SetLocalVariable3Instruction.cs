namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class SetLocalVariable3Instruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value = state.Stack.Pop();
            Method.LocalVariables[3] = value;

            return Method.GetNextInstruction(this);
        }
    }
}