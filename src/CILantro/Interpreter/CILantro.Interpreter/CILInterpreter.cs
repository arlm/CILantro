using CILantro.AST.CILASTNodes;
using System.IO;

namespace CILantro.Interpreter
{
    public class CILInterpreter
    {
        public void Interpret(CILProgram program, StreamReader inputStream, StreamWriter outputStrem)
        {
            outputStrem.WriteLine("TEST");
        }
    }
}