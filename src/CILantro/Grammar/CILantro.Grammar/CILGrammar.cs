using Irony.Parsing;

namespace CILantro.Grammar
{
    public class CILGrammar : Irony.Parsing.Grammar
    {
        public CILGrammar()
        {
            Root = new NonTerminal("TEST");
            Root.Rule = "TEST";
        }
    }
}