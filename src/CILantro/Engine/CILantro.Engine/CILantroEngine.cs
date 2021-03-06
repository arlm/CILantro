﻿using CILantro.AST.CILASTNodes;
using CILantro.Interpreter;
using CILantro.Parser;
using System.IO;

// TODO - REFAKTORING

namespace CILantro.Engine
{
    public class CILantroEngine
    {
        private readonly CILParser _cilParser;
        private readonly CILInterpreter _cilInterpreter;

        public string SourceCode { get; private set; }

        public CILantroEngine(string sourceCode)
        {
            _cilParser = new CILParser();
            _cilInterpreter = new CILInterpreter();

            SourceCode = sourceCode;
        }

        public void Process(StreamReader inputStream, StreamWriter outputStream)
        {
            var programTree = _cilParser.Parse(SourceCode);
            var programInstance = programTree.CreateInstance();

            _cilInterpreter.Interpret(programInstance, inputStream, outputStream);
        }

        public CILProgram Parse()
        {
            return _cilParser.Parse(SourceCode);
        }
    }
}