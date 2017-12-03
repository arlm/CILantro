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

            var INT64_DEC = new NumberLiteral(GrammarNames.LEXICALS_INT64_DEC, NumberOptions.IntOnly | NumberOptions.AllowSign);
            var INT64_HEX = new RegexBasedTerminal(GrammarNames.LEXICALS_INT64_HEX, "0x[A-F0-9]{1,}");
            var INT64 = new NonTerminal(GrammarNames.LEXICALS_INT64);
            INT64.Rule = INT64_DEC | INT64_HEX;

            var SQSTRING = new StringLiteral(GrammarNames.LEXICALS_SQSTRING, "'");

            // id

            var id = new NonTerminal(GrammarNames.id);
            id.Rule =
                ID |
                SQSTRING;

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

            // int64

            var int64 = new NonTerminal(GrammarNames.int64);
            int64.Rule =
                INT64;

            // type

            var type = new NonTerminal(GrammarNames.type);
            type.Rule =
                ToTerm("string") |
                type + ToTerm("[") + ToTerm("]") |
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
                paramAttr + type |
                paramAttr + type + id;

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

            // extendsClause

            var extendsClause = new NonTerminal(GrammarNames.extendsClause);
            extendsClause.Rule =
                Empty |
                ToTerm("extends") + className;

            // implClause

            var implClause = new NonTerminal(GrammarNames.implClause);
            implClause.Rule =
                Empty;

            // implAttr

            var implAttr = new NonTerminal(GrammarNames.implAttr);
            implAttr.Rule =
                Empty |
                implAttr + ToTerm("cil") |
                implAttr + ToTerm("managed");

            // methAttr

            var methAttr = new NonTerminal(GrammarNames.methAttr);
            methAttr.Rule =
                Empty |
                methAttr + ToTerm("static") |
                methAttr + ToTerm("private") |
                methAttr + ToTerm("hidebysig");

            // methodName

            var methodName = new NonTerminal(GrammarNames.methodName);
            methodName.Rule =
                name1;

            // methodHeadPart1

            var methodHeadPart1 = new NonTerminal(GrammarNames.methodHeadPart1);
            methodHeadPart1.Rule =
                ToTerm(".method");

            // methodHead

            var methodHead = new NonTerminal(GrammarNames.methodHead);
            methodHead.Rule =
                methodHeadPart1 + methAttr + callConv + paramAttr + type + methodName + ToTerm("(") + sigArgs0 + ToTerm(")") + implAttr + ToTerm("{");

            // methodDecl

            var methodDecl = new NonTerminal(GrammarNames.methodDecl);
            methodDecl.Rule =
                ToTerm(".entrypoint");

            // methodDecls

            var methodDecls = new NonTerminal(GrammarNames.methodDecls);
            methodDecls.Rule =
                Empty |
                methodDecls + methodDecl;

            // classAttr

            var classAttr = new NonTerminal(GrammarNames.classAttr);
            classAttr.Rule =
                Empty |
                classAttr + ToTerm("private") |
                classAttr + ToTerm("auto") |
                classAttr + ToTerm("ansi") |
                classAttr + ToTerm("beforefieldinit");

            // classDecl

            var classDecl = new NonTerminal(GrammarNames.classDecl);
            classDecl.Rule =
                methodHead + methodDecls + ToTerm("}");

            // classDecls

            var classDecls = new NonTerminal(GrammarNames.classDecls);
            classDecls.Rule =
                Empty |
                classDecls + classDecl;

            // classHead

            var classHead = new NonTerminal(GrammarNames.classHead);
            classHead.Rule =
                ToTerm(".class") + classAttr + name1 + extendsClause + implClause;

            // decl

            var decl = new NonTerminal(GrammarNames.decl);
            decl.Rule =
                classHead + ToTerm("{") + classDecls + ToTerm("}") |
                assemblyHead + ToTerm("{") + assemblyDecls + ToTerm("}") |
                assemblyRefHead + ToTerm("{") + assemblyRefDecls + ToTerm("}") |
                moduleHead |
                ToTerm(".subsystem") + int32 |
                ToTerm(".corflags") + int32 |
                ToTerm(".file") + ToTerm("alignment") + int32 |
                ToTerm(".imagebase") + int64 |
                ToTerm(".stackreserve") + int64;

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