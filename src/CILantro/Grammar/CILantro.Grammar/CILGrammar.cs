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

            // reserved words

            var reservedWords = new string[]
            {
                "(",
                ")",
                "{",
                "}",
                "[",
                "]",
                "/",
                "=",
                ":",
                "::",
                ".assembly",
                ".class",
                ".corflags",
                ".ctor",
                ".custom",
                ".entrypoint",
                ".file",
                ".hash",
                ".imagebase",
                ".maxstack",
                ".method",
                ".module",
                ".publickeytoken",
                ".stackreserve",
                ".subsystem",
                ".ver",
                "alignment",
                "algorithm",
                "ansi",
                "auto",
                "beforefieldinit",
                "bool",
                "call",
                "cil",
                "extends",
                "extern",
                "hidebysig",
                "instance",
                "int32",
                "ldarg.0",
                "ldstr",
                "managed",
                "private",
                "public",
                "ret",
                "rtspecialname",
                "specialname",
                "static",
                "string",
                "void"
            };

            MarkReservedWords(reservedWords);

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

            var QSTRING = new StringLiteral(GrammarNames.LEXICALS_QSTRING, "\"");

            // non-terminals

            var asmAttr = new NonTerminal(GrammarNames.asmAttr);
            var asmOrRefDecl = new NonTerminal(GrammarNames.asmOrRefDecl);
            var assemblyDecl = new NonTerminal(GrammarNames.assemblyDecl);
            var assemblyDecls = new NonTerminal(GrammarNames.assemblyDecls);
            var assemblyHead = new NonTerminal(GrammarNames.assemblyHead);
            var assemblyRefDecl = new NonTerminal(GrammarNames.assemblyRefDecl);
            var assemblyRefDecls = new NonTerminal(GrammarNames.assemblyRefDecls);
            var assemblyRefHead = new NonTerminal(GrammarNames.assemblyRefHead);
            var bytes = new NonTerminal(GrammarNames.bytes);
            var callConv = new NonTerminal(GrammarNames.callConv);
            var callKind = new NonTerminal(GrammarNames.callKind);
            var classAttr = new NonTerminal(GrammarNames.classAttr);
            var classDecl = new NonTerminal(GrammarNames.classDecl);
            var classDecls = new NonTerminal(GrammarNames.classDecls);
            var classHead = new NonTerminal(GrammarNames.classHead);
            var className = new NonTerminal(GrammarNames.className);
            var compQstring = new NonTerminal(GrammarNames.compQstring);
            var customAttrDecl = new NonTerminal(GrammarNames.customAttrDecl);
            var customHead = new NonTerminal(GrammarNames.customHead);
            var customType = new NonTerminal(GrammarNames.customType);
            var decl = new NonTerminal(GrammarNames.decl);
            var decls = new NonTerminal(GrammarNames.decls);
            var extendsClause = new NonTerminal(GrammarNames.extendsClause);
            var hexbytes = new NonTerminal(GrammarNames.hexbytes);
            var id = new NonTerminal(GrammarNames.id);
            var implAttr = new NonTerminal(GrammarNames.implAttr);
            var implClause = new NonTerminal(GrammarNames.implClause);
            var instr = new NonTerminal(GrammarNames.instr);
            var int32 = new NonTerminal(GrammarNames.int32);
            var int64 = new NonTerminal(GrammarNames.int64);
            var methAttr = new NonTerminal(GrammarNames.methAttr);
            var methodDecl = new NonTerminal(GrammarNames.methodDecl);
            var methodDecls = new NonTerminal(GrammarNames.methodDecls);
            var methodHead = new NonTerminal(GrammarNames.methodHead);
            var methodHeadPart1 = new NonTerminal(GrammarNames.methodHeadPart1);
            var methodName = new NonTerminal(GrammarNames.methodName);
            var moduleHead = new NonTerminal(GrammarNames.moduleHead);
            var name1 = new NonTerminal(GrammarNames.name1);
            var paramAttr = new NonTerminal(GrammarNames.paramAttr);
            var publicKeyTokenHead = new NonTerminal(GrammarNames.publicKeyTokenHead);
            var sigArg = new NonTerminal(GrammarNames.sigArg);
            var sigArgs0 = new NonTerminal(GrammarNames.sigArgs0);
            var sigArgs1 = new NonTerminal(GrammarNames.sigArgs1);
            var slashedName = new NonTerminal(GrammarNames.slashedName);
            var start = new NonTerminal(GrammarNames.start);
            var type = new NonTerminal(GrammarNames.type);
            var typeSpec = new NonTerminal(GrammarNames.typeSpec);

            // instructions

            var INSTR_METHOD = new NonTerminal(GrammarNames.INSTR_METHOD);
            INSTR_METHOD.Rule =
                ToTerm("call");

            var INSTR_NONE = new NonTerminal(GrammarNames.INSTR_NONE);
            INSTR_NONE.Rule =
                ToTerm("ldarg.0") |
                ToTerm("ret");

            var INSTR_STRING = new NonTerminal(GrammarNames.INSTR_STRING);
            INSTR_STRING.Rule =
                ToTerm("ldstr");

            // rules

            Root = start;

            start.Rule =
                decls;

            decls.Rule =
                Empty |
                decls + decl;

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

            compQstring.Rule =
                QSTRING;

            customAttrDecl.Rule =
                customHead + bytes + ToTerm(")");

            moduleHead.Rule =
                ToTerm(".module") + name1;

            classHead.Rule =
                ToTerm(".class") + classAttr + name1 + extendsClause + implClause;

            classAttr.Rule =
                Empty |
                classAttr + ToTerm("private") |
                classAttr + ToTerm("auto") |
                classAttr + ToTerm("ansi") |
                classAttr + ToTerm("beforefieldinit");

            extendsClause.Rule =
                Empty |
                ToTerm("extends") + className;

            implClause.Rule =
                Empty;

            classDecls.Rule =
                Empty |
                classDecls + classDecl;

            classDecl.Rule =
                methodHead + methodDecls + ToTerm("}");

            customHead.Rule =
                ToTerm(".custom") + customType + ToTerm("=") + ToTerm("(");

            customType.Rule =
                callConv + type + typeSpec + ToTerm("::") + ToTerm(".ctor") + ToTerm("(") + sigArgs0 + ToTerm(")") |
                callConv + type + ToTerm(".ctor") + ToTerm("(") + sigArgs0 + ToTerm(")");

            methodHeadPart1.Rule =
                ToTerm(".method");

            methodHead.Rule =
                methodHeadPart1 + methAttr + callConv + paramAttr + type + methodName + ToTerm("(") + sigArgs0 + ToTerm(")") + implAttr + ToTerm("{");

            methAttr.Rule =
                Empty |
                methAttr + ToTerm("static") |
                methAttr + ToTerm("public") |
                methAttr + ToTerm("private") |
                methAttr + ToTerm("specialname") |
                methAttr + ToTerm("hidebysig") |
                methAttr + ToTerm("rtspecialname");

            methodName.Rule =
                ToTerm(".ctor") |
                name1;

            paramAttr.Rule =
                Empty;

            implAttr.Rule =
                Empty |
                implAttr + ToTerm("cil") |
                implAttr + ToTerm("managed");

            methodDecl.Rule =
                ToTerm(".maxstack") + int32 |
                ToTerm(".entrypoint") |
                instr |
                id + ToTerm(":");

            methodDecls.Rule =
                Empty |
                methodDecls + methodDecl;

            bytes.Rule =
                Empty |
                hexbytes;

            hexbytes.Rule =
                HEXBYTE |
                hexbytes + HEXBYTE;

            instr.Rule =
                INSTR_NONE |
                INSTR_METHOD + callConv + type + typeSpec + ToTerm("::") + methodName + ToTerm("(") + sigArgs0 + ToTerm(")") |
                INSTR_STRING + compQstring;

            sigArgs0.Rule =
                Empty |
                sigArgs1;

            sigArgs1.Rule =
                sigArg;

            sigArg.Rule =
                paramAttr + type |
                paramAttr + type + id;

            name1.Rule =
                id |
                name1 + ToTerm(".") + name1;

            className.Rule =
                ToTerm("[") + name1 + ToTerm("]") + slashedName;

            slashedName.Rule =
                name1 |
                slashedName + ToTerm("/") + name1;

            typeSpec.Rule =
                className;

            callConv.Rule =
                ToTerm("instance") + callConv |
                callKind;

            callKind.Rule =
                Empty;

            type.Rule =
                ToTerm("string") |
                type + ToTerm("[") + ToTerm("]") |
                ToTerm("void") |
                ToTerm("bool") |
                ToTerm("int32");

            id.Rule =
                ID |
                SQSTRING;

            int32.Rule =
                INT32;

            int64.Rule =
                INT64;

            assemblyHead.Rule =
                ToTerm(".assembly") + asmAttr + name1;

            asmAttr.Rule =
                Empty;

            assemblyDecls.Rule =
                Empty |
                assemblyDecls + assemblyDecl;

            assemblyDecl.Rule =
                ToTerm(".hash") + ToTerm("algorithm") + int32 |
                asmOrRefDecl;

            asmOrRefDecl.Rule =
                ToTerm(".ver") + int32 + ToTerm(":") + int32 + ToTerm(":") + int32 + ToTerm(":") + int32 |
                customAttrDecl;

            publicKeyTokenHead.Rule =
                ToTerm(".publickeytoken") + ToTerm("=") + ToTerm("(");

            assemblyRefHead.Rule =
                ToTerm(".assembly") + ToTerm("extern") + name1;

            assemblyRefDecls.Rule =
                Empty |
                assemblyRefDecls + assemblyRefDecl;

            assemblyRefDecl.Rule =
                asmOrRefDecl |
                publicKeyTokenHead + bytes + ToTerm(")");
        }
    }
}