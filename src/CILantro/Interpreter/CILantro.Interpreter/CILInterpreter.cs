using CILantro.AST.CILASTNodes;
using CILantro.State;
using System.IO;
using System.Linq;

namespace CILantro.Interpreter
{
    public class CILInterpreter
    {
        public void Interpret(CILProgram program, StreamReader inputStream, StreamWriter outputStrem)
        {
            var state = new CILProgramState();

            var instruction = program.EntryPoint.Instructions.First();
            while(instruction != null)
            {
                instruction = instruction.Execute(state, program);
            }
        }
    }
}