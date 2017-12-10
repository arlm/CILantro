using CILantro.AST.CILASTNodes;
using System.IO;

namespace CILantro.Interpreter
{
    public class CILInterpreter
    {
        public void Interpret(CILProgram programTree, StreamReader inputStream, StreamWriter outputStrem)
        {
            outputStrem.WriteLine("TEST");
        }
    }
}