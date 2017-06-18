namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadLocalVariable2Instruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value = Method.LocalVariables[2];
            state.Stack.Push(value);

            return Method.GetNextInstruction(this);
        }
    }
}