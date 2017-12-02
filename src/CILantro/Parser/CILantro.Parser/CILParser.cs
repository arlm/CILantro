using CILantro.AST;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using System;
using System.Linq;

namespace CILantro.Parser
{
    public class CILParser
    {
        private readonly Irony.Parsing.Parser _ironyParser;

        public CILParser()
        {
            _ironyParser = new Irony.Parsing.Parser(new CILGrammar());
        }

        public CILProgramTree Parse(string sourceCode)
        {
            var parseTree = _ironyParser.Parse(sourceCode);
            if(parseTree.Status == Irony.Parsing.ParseTreeStatus.Parsed)
            {
                return new CILProgramTree();
            }

            throw new ArgumentException(parseTree.ParserMessages.First().UserFriendlyMessage());
        }
    }
}