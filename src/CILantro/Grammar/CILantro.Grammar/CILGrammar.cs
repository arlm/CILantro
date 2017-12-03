using Irony.Parsing;

namespace CILantro.Grammar
{
    public class CILGrammar : Irony.Parsing.Grammar
    {
        public CILGrammar()
        {
            // comments

            var lineComment = new CommentTerminal(GrammarNames.COMMENTS_LINECOMMENT, "//", "\n");

            NonGrammarTerminals.Add(lineComment);

            // lexical tokens

            var HEXBYTE = new RegexBasedTerminal(GrammarNames.LEXICALS_HEXBYTE, "[A-F0-9]{2}");
            var ID = new IdentifierTerminal(GrammarNames.LEXICALS_ID);
            var INT32 = new NumberLiteral(GrammarNames.LEXICALS_INT32, NumberOptions.IntOnly | NumberOptions.AllowSign);

            // id

            var id = new NonTerminal(GrammarNames.id);
            id.Rule =
                ID;

            // name1

            var name1 = new NonTerminal(GrammarNames.name1);
            name1.Rule =
                id;

            // hexbytes

            var hexbytes = new NonTerminal(GrammarNames.hexbytes);
            hexbytes.Rule =
                HEXBYTE |
                hexbytes + HEXBYTE;

            // bytes

            var bytes = new NonTerminal(GrammarNames.bytes);
            bytes.Rule =
                Empty |
                hexbytes;

            // int32

            var int32 = new NonTerminal(GrammarNames.int32);
            int32.Rule =
                INT32;

            // assemblyRefHead

            var assemblyRefHead = new NonTerminal(GrammarNames.assemblyRefHead);
            assemblyRefHead.Rule =
                ToTerm(".assembly") + ToTerm("extern") + name1;

            // publicKeyTokenHead

            var publicKeyTokenHead = new NonTerminal(GrammarNames.publicKeyTokenHead);
            publicKeyTokenHead.Rule =
                ToTerm(".publickeytoken") + ToTerm("=") + ToTerm("(");

            // asmOrRefDecl

            var asmOrRefDecl = new NonTerminal(GrammarNames.asmOrRefDecl);
            asmOrRefDecl.Rule =
                ToTerm(".ver") + int32 + ToTerm(":") + int32 + ToTerm(":") + int32 + ToTerm(":") + int32;

            // assemblyRefDecl

            var assemblyRefDecl = new NonTerminal(GrammarNames.assemblyRefDecl);
            assemblyRefDecl.Rule =
                asmOrRefDecl |
                publicKeyTokenHead + bytes + ToTerm(")");

            // assemblyRefDecls

            var assemblyRefDecls = new NonTerminal(GrammarNames.assemblyRefDecls);
            assemblyRefDecls.Rule =
                Empty |
                assemblyRefDecls + assemblyRefDecl;

            // decl

            var decl = new NonTerminal(GrammarNames.decl);
            decl.Rule =
                assemblyRefHead + ToTerm("{") + assemblyRefDecls + ToTerm("}");

            // decls

            var decls = new NonTerminal(GrammarNames.decls);
            decls.Rule =
                Empty |
                decls + decl;

            // start

            var start = new NonTerminal(GrammarNames.start);
            start.Rule =
                decls;

            // root

            Root = start;
        }
    }
}