using CILantro.AST;
using System.IO;

namespace CILantro.Interpreter
{
    public class CILInterpreter
    {
        public void Interpret(CILProgramTree programTree, StreamReader inputStream, StreamWriter outputStrem)
        {
            outputStrem.WriteLine("TEST");
        }
    }
}