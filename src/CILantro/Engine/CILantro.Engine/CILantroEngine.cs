using System.IO;

namespace CILantro.Engine
{
    public class CILantroEngine
    {
        public string SourceCode { get; private set; }

        public CILantroEngine(string sourceCode)
        {
            SourceCode = sourceCode;
        }

        public void Process(StreamReader inputStream, StreamWriter outputStream)
        {
            outputStream.WriteLine("TEST");
        }
    }
}