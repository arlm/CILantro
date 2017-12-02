using Irony.Parsing;

namespace CILantro.Grammar
{
    public class CILGrammar : Irony.Parsing.Grammar
    {
        public CILGrammar()
        {
            // comments

            var lineComment = new CommentTerminal(GrammarNames.LineComment, "//", "\n");

            NonGrammarTerminals.Add(lineComment);

            // root

            Root = new NonTerminal("TEST");
            Root.Rule = "TEST";
        }
    }
}