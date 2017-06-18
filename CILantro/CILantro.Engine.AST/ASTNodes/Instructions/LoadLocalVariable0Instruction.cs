namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadLocalVariable0Instruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value = Method.LocalVariables[0];
            state.Stack.Push(value);

            return Method.GetNextInstruction(this);
        }
    }
}