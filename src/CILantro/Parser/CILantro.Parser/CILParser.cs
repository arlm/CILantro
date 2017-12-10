using CILantro.AST.CILASTNodes;
using CILantro.ASTBuilder;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using System;
using System.Linq;

namespace CILantro.Parser
{
    public class CILParser
    {
        private readonly Irony.Parsing.Parser _ironyParser;
        private readonly CILASTBuilder _astBuilder;

        public CILParser()
        {
            _ironyParser = new Irony.Parsing.Parser(new CILGrammar());
            _astBuilder = new CILASTBuilder();
        }

        public CILProgram Parse(string sourceCode)
        {
            var parseTree = _ironyParser.Parse(sourceCode);
            if(parseTree.Status == Irony.Parsing.ParseTreeStatus.Parsed)
            {
                var programTree = _astBuilder.BuildAST(parseTree);
                return programTree;
            }

            throw new ArgumentException(parseTree.ParserMessages.First().UserFriendlyMessage());
        }
    }
}