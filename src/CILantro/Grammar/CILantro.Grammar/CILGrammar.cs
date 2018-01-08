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
                "<",
                ">",
                "/",
                "=",
                ":",
                "::",
                ",",
                "`",
                "!",
                "!!",
                "$",
                "&",
                ".assembly",
                ".cctor",
                ".class",
                ".corflags",
                ".ctor",
                ".custom",
                ".entrypoint",
                ".field",
                ".file",
                ".get",
                ".hash",
                ".imagebase",
                ".locals",
                ".maxstack",
                ".method",
                ".module",
                ".mresource",
                ".property",
                ".publickeytoken",
                ".set",
                ".stackreserve",
                ".subsystem",
                ".ver",
                "abstract",
                "alignment",
                "algorithm",
                "ansi",
                "assembly",
                "auto",
                "beforefieldinit",
                "bool",
                "box",
                "br.s",
                "brfalse.s",
                "brtrue.s",
                "call",
                "callvirt",
                "castclass",
                "cil",
                "class",
                "extends",
                "extern",
                "field",
                "hidebysig",
                "init",
                "initobj",
                "initonly",
                "instance",
                "int32",
                "ldarg.0",
                "ldarg.1",
                "ldc.i4.0",
                "ldc.i4.1",
                "ldc.i4.s",
                "ldloc.0",
                "ldloc.1",
                "ldloc.2",
                "ldloc.3",
                "ldloc.s",
                "ldnull",
                "ldsfld",
                "ldstr",
                "ldtoken",
                "managed",
                "nested",
                "newobj",
                "nop",
                "object",
                "pop",
                "private",
                "public",
                "ret",
                "rtspecialname",
                "sealed",
                "specialname",
                "static",
                "stloc.0",
                "stloc.1",
                "stloc.2",
                "stloc.3",
                "stloc.s",
                "strict",
                "string",
                "stsfld",
                "valuetype",
                "virtual",
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
            var atOpt = new NonTerminal(GrammarNames.atOpt);
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
            var fieldAttr = new NonTerminal(GrammarNames.fieldAttr);
            var fieldDecl = new NonTerminal(GrammarNames.fieldDecl);
            var genericClassName = new NonTerminal(GrammarNames.genericClassName);
            var genericMethodName = new NonTerminal(GrammarNames.genericMethodName);
            var hexbytes = new NonTerminal(GrammarNames.hexbytes);
            var id = new NonTerminal(GrammarNames.id);
            var implAttr = new NonTerminal(GrammarNames.implAttr);
            var implClause = new NonTerminal(GrammarNames.implClause);
            var initOpt = new NonTerminal(GrammarNames.initOpt);
            var instr = new NonTerminal(GrammarNames.instr);
            var instr_tok_head = new NonTerminal(GrammarNames.instr_tok_head);
            var int32 = new NonTerminal(GrammarNames.int32);
            var int64 = new NonTerminal(GrammarNames.int64);
            var localsHead = new NonTerminal(GrammarNames.localsHead);
            var manifestResDecl = new NonTerminal(GrammarNames.manifestResDecl);
            var manifestResDecls = new NonTerminal(GrammarNames.manifestResDecls);
            var manifestResHead = new NonTerminal(GrammarNames.manifestResHead);
            var manresAttr = new NonTerminal(GrammarNames.manresAttr);
            var memberRef = new NonTerminal(GrammarNames.memberRef);
            var methAttr = new NonTerminal(GrammarNames.methAttr);
            var methodDecl = new NonTerminal(GrammarNames.methodDecl);
            var methodDecls = new NonTerminal(GrammarNames.methodDecls);
            var methodHead = new NonTerminal(GrammarNames.methodHead);
            var methodHeadPart1 = new NonTerminal(GrammarNames.methodHeadPart1);
            var methodName = new NonTerminal(GrammarNames.methodName);
            var moduleHead = new NonTerminal(GrammarNames.moduleHead);
            var name1 = new NonTerminal(GrammarNames.name1);
            var ownerType = new NonTerminal(GrammarNames.ownerType);
            var paramAttr = new NonTerminal(GrammarNames.paramAttr);
            var propAttr = new NonTerminal(GrammarNames.propAttr);
            var propDecl = new NonTerminal(GrammarNames.propDecl);
            var propDecls = new NonTerminal(GrammarNames.propDecls);
            var propHead = new NonTerminal(GrammarNames.propHead);
            var publicKeyTokenHead = new NonTerminal(GrammarNames.publicKeyTokenHead);
            var repeatOpt = new NonTerminal(GrammarNames.repeatOpt);
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
                ToTerm("call") |
                ToTerm("callvirt") |
                ToTerm("newobj");

            var INSTR_NONE = new NonTerminal(GrammarNames.INSTR_NONE);
            INSTR_NONE.Rule =
                ToTerm("add") |
                ToTerm("and") |
                ToTerm("ceq") |
                ToTerm("cgt") |
                ToTerm("clt") |
                ToTerm("div") |
                ToTerm("dup") |
                ToTerm("ldarg.0") |
                ToTerm("ldarg.1") |
                ToTerm("ldc.i4.0") |
                ToTerm("ldc.i4.1") |
                ToTerm("ldloc.0") |
                ToTerm("ldloc.1") |
                ToTerm("ldloc.2") |
                ToTerm("ldloc.3") |
                ToTerm("ldnull") |
                ToTerm("mul") |
                ToTerm("nop") |
                ToTerm("not") |
                ToTerm("or") |
                ToTerm("pop") |
                ToTerm("rem") |
                ToTerm("ret") |
                ToTerm("shl") |
                ToTerm("shr") |
                ToTerm("stloc.0") |
                ToTerm("stloc.1") |
                ToTerm("stloc.2") |
                ToTerm("stloc.3") |
                ToTerm("sub") |
                ToTerm("xor");

            var INSTR_VAR = new NonTerminal(GrammarNames.INSTR_VAR);
            INSTR_VAR.Rule =
                ToTerm("ldloc.s") |
                ToTerm("stloc.s");

            var INSTR_I = new NonTerminal(GrammarNames.INSTR_I);
            INSTR_I.Rule =
                ToTerm("ldc.i4.s");

            var INSTR_BRTARGET = new NonTerminal(GrammarNames.INSTR_BRTARGET);
            INSTR_BRTARGET.Rule =
                ToTerm("br.s") |
                ToTerm("brfalse.s") |
                ToTerm("brtrue.s");

            var INSTR_FIELD = new NonTerminal(GrammarNames.INSTR_FIELD);
            INSTR_FIELD.Rule =
                ToTerm("ldsfld") |
                ToTerm("stsfld");

            var INSTR_TYPE = new NonTerminal(GrammarNames.INSTR_TYPE);
            INSTR_TYPE.Rule =
                ToTerm("box") |
                ToTerm("castclass") |
                ToTerm("initobj");

            var INSTR_STRING = new NonTerminal(GrammarNames.INSTR_STRING);
            INSTR_STRING.Rule =
                ToTerm("ldstr");

            var INSTR_TOK = new NonTerminal(GrammarNames.INSTR_TOK);
            INSTR_TOK.Rule =
                ToTerm("ldtoken");

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
                manifestResHead + ToTerm("{") + manifestResDecls + ToTerm("}") |
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
                ToTerm(".class") + classAttr + className + extendsClause + implClause;

            classAttr.Rule =
                Empty |
                classAttr + ToTerm("public") |
                classAttr + ToTerm("private") |
                classAttr + ToTerm("sealed") |
                classAttr + ToTerm("abstract") |
                classAttr + ToTerm("auto") |
                classAttr + ToTerm("ansi") |
                classAttr + ToTerm("nested") + ToTerm("assembly") |
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
                methodHead + methodDecls + ToTerm("}") |
                classHead + ToTerm("{") + classDecls + ToTerm("}") |
                propHead + ToTerm("{") + propDecls + ToTerm("}") |
                fieldDecl |
                customAttrDecl;

            fieldDecl.Rule =
                ToTerm(".field") + repeatOpt + fieldAttr + type + id + atOpt + initOpt;

            atOpt.Rule =
                Empty;

            initOpt.Rule =
                Empty;

            repeatOpt.Rule =
                Empty;

            customHead.Rule =
                ToTerm(".custom") + customType + ToTerm("=") + ToTerm("(");

            memberRef.Rule =
                ToTerm("field") + type + id;

            customType.Rule =
                callConv + type + typeSpec + ToTerm("::") + ToTerm(".ctor") + ToTerm("(") + sigArgs0 + ToTerm(")") |
                callConv + type + ToTerm(".ctor") + ToTerm("(") + sigArgs0 + ToTerm(")");

            ownerType.Rule =
                typeSpec |
                memberRef;

            propHead.Rule =
                ToTerm(".property") + propAttr + callConv + type + id + ToTerm("(") + sigArgs0 + ToTerm(")") + initOpt;

            propAttr.Rule =
                Empty;

            propDecls.Rule =
                Empty |
                propDecls + propDecl;

            propDecl.Rule =
                ToTerm(".set") + callConv + type + typeSpec + ToTerm("::") + methodName + ToTerm("(") + sigArgs0 + ToTerm(")") |
                ToTerm(".get") + callConv + type + typeSpec + ToTerm("::") + methodName + ToTerm("(") + sigArgs0 + ToTerm(")") |
                ToTerm(".get") + callConv + type + methodName + ToTerm("(") + sigArgs0 + ToTerm(")") |
                customAttrDecl;

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
                methAttr + ToTerm("virtual") |
                methAttr + ToTerm("assembly") |
                methAttr + ToTerm("hidebysig") |
                methAttr + ToTerm("rtspecialname") |
                methAttr + ToTerm("strict");

            methodName.Rule =
                ToTerm(".ctor") |
                ToTerm(".cctor") |
                name1 |
                genericMethodName;

            genericMethodName.Rule =
                name1 + ToTerm("<") + sigArgs0 + ToTerm(">") |
                name1 + ToTerm("<") + id + ToTerm(">") |
                name1 + ToTerm("<") + methodName + id + ToTerm(">");

            paramAttr.Rule =
                Empty |
                paramAttr + ToTerm("[") + int32 + ToTerm("]");

            fieldAttr.Rule =
                Empty |
                fieldAttr + ToTerm("static") |
                fieldAttr + ToTerm("private") |
                fieldAttr + ToTerm("initonly");

            implAttr.Rule =
                Empty |
                implAttr + ToTerm("cil") |
                implAttr + ToTerm("managed");

            localsHead.Rule =
                ToTerm(".locals");

            methodDecl.Rule =
                ToTerm(".maxstack") + int32 |
                localsHead + ToTerm("init") + ToTerm("(") + sigArgs0 + ToTerm(")") |
                ToTerm(".entrypoint") |
                instr |
                id + ToTerm(":") |
                customAttrDecl;

            methodDecls.Rule =
                Empty |
                methodDecls + methodDecl;

            bytes.Rule =
                Empty |
                hexbytes;

            hexbytes.Rule =
                HEXBYTE |
                hexbytes + HEXBYTE;

            instr_tok_head.Rule =
                INSTR_TOK;

            instr.Rule =
                INSTR_NONE |
                INSTR_VAR + id |
                INSTR_I + int32 |
                INSTR_BRTARGET + id |
                INSTR_METHOD + callConv + type + typeSpec + ToTerm("::") + methodName + ToTerm("(") + sigArgs0 + ToTerm(")") |
                INSTR_METHOD + callConv + type + methodName + ToTerm("(") + sigArgs0 + ToTerm(")") |
                INSTR_FIELD + type + typeSpec + ToTerm("::") + id |
                INSTR_TYPE + typeSpec |
                INSTR_STRING + compQstring |
                instr_tok_head + ownerType;

            sigArgs0.Rule =
                Empty |
                sigArgs1;

            sigArgs1.Rule =
                sigArg |
                sigArgs1 + ToTerm(",") + sigArg;

            sigArg.Rule =
                paramAttr + type |
                paramAttr + type + id;

            name1.Rule =
                id |
                name1 + ToTerm(".") + name1;

            className.Rule =
                ToTerm("[") + name1 + ToTerm("]") + slashedName |
                slashedName |
                genericClassName;

            genericClassName.Rule =
                className + ToTerm("`") + int32 |
                className + ToTerm("`") + int32 + ToTerm("<") + sigArgs0 + ToTerm(">") |
                className + ToTerm("`") + int32 + ToTerm("<") + methodName + id + ToTerm(">");

            slashedName.Rule =
                name1 |
                slashedName + ToTerm("/") + name1;

            typeSpec.Rule =
                className |
                type;

            callConv.Rule =
                ToTerm("instance") + callConv |
                callKind;

            callKind.Rule =
                Empty;

            type.Rule =
                ToTerm("class") + className |
                ToTerm("object") |
                ToTerm("string") |
                ToTerm("valuetype") + className |
                type + ToTerm("[") + ToTerm("]") |
                type + ToTerm("&") |
                ToTerm("!") + int32 |
                ToTerm("!") + id |
                ToTerm("!!") + int32 |
                ToTerm("!!") + id |
                ToTerm("char") |
                ToTerm("void") |
                ToTerm("bool") |
                ToTerm("int8") |
                ToTerm("int16") |
                ToTerm("int32") |
                ToTerm("int64") |
                ToTerm("float32") |
                ToTerm("float64") |
                ToTerm("uint8") |
                ToTerm("uint16") |
                ToTerm("uint32") |
                ToTerm("uint64");

            id.Rule =
                ID |
                ToTerm("$") + ID |
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

            manifestResHead.Rule =
                ToTerm(".mresource") + manresAttr + name1;

            manresAttr.Rule =
                Empty |
                manresAttr + ToTerm("public");

            manifestResDecls.Rule =
                Empty |
                manifestResDecls + manifestResDecl;

            manifestResDecl.Rule =
                customAttrDecl;
        }
    }
}