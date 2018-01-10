using CILantro.AST.CILASTNodes;
using CILantro.Interpreter;
using CILantro.Parser;
using CILantro.Reflection;
using System.IO;
using System.Linq;

namespace CILantro.Engine
{
    public class CILantroEngine
    {
        private readonly CILParser _cilParser;
        private readonly CILInterpreter _cilInterpreter;
        private readonly RuntimeTypeCreator _runtimeTypeCreator;

        public string SourceCode { get; private set; }

        public CILantroEngine(string sourceCode)
        {
            _cilParser = new CILParser();
            _cilInterpreter = new CILInterpreter();
            _runtimeTypeCreator = new RuntimeTypeCreator();

            SourceCode = sourceCode;
        }

        public void Process(StreamReader inputStream, StreamWriter outputStream)
        {
            var programTree = _cilParser.Parse(SourceCode);

            var defaultAssembly = programTree.Assemblies.First();
            var defaultModule = programTree.Modules.First();

            RuntimeTypeManager.DefaultAssemblyName = defaultAssembly.AssemblyName;

            var assemblyBuilder = _runtimeTypeCreator.CreateAssemblyBuilder(defaultAssembly);
            var moduleBuilder = _runtimeTypeCreator.CreateModuleBuilder(assemblyBuilder, defaultModule);
            foreach(var cilClass in programTree.Classes)
            {
                _runtimeTypeCreator.CreateType(moduleBuilder, cilClass);
            }

            _cilInterpreter.Interpret(programTree, inputStream, outputStream);
        }

        public CILProgram Parse()
        {
            return _cilParser.Parse(SourceCode);
        }
    }
}