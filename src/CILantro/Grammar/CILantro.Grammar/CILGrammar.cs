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

            var INT32_DEC = new NumberLiteral(GrammarNames.LEXICALS_INT32_DEC, NumberOptions.IntOnly | NumberOptions.AllowSign);
            var INT32_HEX = new RegexBasedTerminal(GrammarNames.LEXICALS_INT32_HEX, "0x[A-F0-9]{1,}");
            var INT32 = new NonTerminal(GrammarNames.LEXICALS_INT32);
            INT32.Rule = INT32_DEC | INT32_HEX;

            // id

            var id = new NonTerminal(GrammarNames.id);
            id.Rule =
                ID;

            // name1

            var name1 = new NonTerminal(GrammarNames.name1);
            name1.Rule =
                id |
                name1 + ToTerm(".") + name1;

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

            // type

            var type = new NonTerminal(GrammarNames.type);
            type.Rule =
                ToTerm("string") |
                ToTerm("void") |
                ToTerm("bool") |
                ToTerm("int32");

            // paramAttr

            var paramAttr = new NonTerminal(GrammarNames.paramAttr);
            paramAttr.Rule =
                Empty;

            // sigArg

            var sigArg = new NonTerminal(GrammarNames.sigArg);
            sigArg.Rule =
                paramAttr + type;

            // sigArgs1

            var sigArgs1 = new NonTerminal(GrammarNames.sigArgs1);
            sigArgs1.Rule =
                sigArg;

            // sigArgs0

            var sigArgs0 = new NonTerminal(GrammarNames.sigArgs0);
            sigArgs0.Rule =
                Empty |
                sigArgs1;

            // slashedName

            var slashedName = new NonTerminal(GrammarNames.slashedName);
            slashedName.Rule =
                name1 |
                slashedName + ToTerm("/") + name1;

            // className

            var className = new NonTerminal(GrammarNames.className);
            className.Rule =
                ToTerm("[") + name1 + ToTerm("]") + slashedName;

            // typeSpec

            var typeSpec = new NonTerminal(GrammarNames.typeSpec);
            typeSpec.Rule =
                className;

            // callKind

            var callKind = new NonTerminal(GrammarNames.callKind);
            callKind.Rule =
                Empty;

            // callConv

            var callConv = new NonTerminal(GrammarNames.callConv);
            callConv.Rule =
                ToTerm("instance") + callConv |
                callKind;

            // customType

            var customType = new NonTerminal(GrammarNames.customType);
            customType.Rule =
                callConv + type + typeSpec + ToTerm("::") + ToTerm(".ctor") + ToTerm("(") + sigArgs0 + ToTerm(")") |
                callConv + type + ToTerm(".ctor") + ToTerm("(") + sigArgs0 + ToTerm(")");

            // customHead

            var customHead = new NonTerminal(GrammarNames.customHead);
            customHead.Rule =
                ToTerm(".custom") + customType + ToTerm("=") + ToTerm("(");

            // customAttrDecl

            var customAttrDecl = new NonTerminal(GrammarNames.customAttrDecl);
            customAttrDecl.Rule =
                customHead + bytes + ToTerm(")");

            // asmAttr

            var asmAttr = new NonTerminal(GrammarNames.asmAttr);
            asmAttr.Rule =
                Empty;

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
                ToTerm(".ver") + int32 + ToTerm(":") + int32 + ToTerm(":") + int32 + ToTerm(":") + int32 |
                customAttrDecl;

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

            // assemblyHead

            var assemblyHead = new NonTerminal(GrammarNames.assemblyHead);
            assemblyHead.Rule =
                ToTerm(".assembly") + asmAttr + name1;

            // assemblyDecl

            var assemblyDecl = new NonTerminal(GrammarNames.assemblyDecl);
            assemblyDecl.Rule =
                ToTerm(".hash") + ToTerm("algorithm") + int32 |
                asmOrRefDecl;

            // assemblyDecls

            var assemblyDecls = new NonTerminal(GrammarNames.assemblyDecls);
            assemblyDecls.Rule =
                Empty |
                assemblyDecls + assemblyDecl;

            // moduleHead

            var moduleHead = new NonTerminal(GrammarNames.moduleHead);
            moduleHead.Rule =
                ToTerm(".module") + name1;

            // decl

            var decl = new NonTerminal(GrammarNames.decl);
            decl.Rule =
                assemblyHead + ToTerm("{") + assemblyDecls + ToTerm("}") |
                assemblyRefHead + ToTerm("{") + assemblyRefDecls + ToTerm("}") |
                moduleHead;

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