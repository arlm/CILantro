using Irony.Parsing;

namespace CILantro.Engine.Parser
{
    internal class CILGrammar : Grammar
    {
        public CILGrammar()
        {
            // comments

            var lineComment = new CommentTerminal(GrammarNames.LineComment, "//", "\n");

            NonGrammarTerminals.Add(lineComment);

            // punctuation

            var colon = ToTerm(":", GrammarNames.Colon);
            var dot = ToTerm(".", GrammarNames.Dot);
            var comma = ToTerm(",", GrammarNames.Comma);
            var plus = ToTerm("+", GrammarNames.Plus);
            var equalsSign = ToTerm("=", GrammarNames.EqualsSign);
            var leftBrace = ToTerm("{", GrammarNames.LeftBrace);
            var rightBrace = ToTerm("}", GrammarNames.RightBrace);
            var leftParenthesis = ToTerm("(", GrammarNames.LeftParenthesis);
            var rightParenthesis = ToTerm(")", GrammarNames.RightParenthesis);
            var leftSquareBracket = ToTerm("[", GrammarNames.LeftSquareBracket);
            var rightSquareBracket = ToTerm("]", GrammarNames.RightSquareBracket);

            // tokens

            var addToken = ToTerm("add", GrammarNames.AddToken);
            var addovfToken = new NonTerminal(GrammarNames.AddovfToken);
            addovfToken.Rule = ToTerm("add") + dot + ToTerm("ovf");
            var addovfunToken = new NonTerminal(GrammarNames.AddovfunToken);
            addovfunToken.Rule = ToTerm("add") + dot + ToTerm("ovf") + dot + ToTerm("un");
            var algorithmToken = ToTerm("algorithm", GrammarNames.AlgorithmToken);
            var alignmentToken = ToTerm("alignment", GrammarNames.AlignmentToken);
            var andToken = ToTerm("and", GrammarNames.AndToken);
            var ansiToken = ToTerm("ansi", GrammarNames.AnsiToken);
            var autoToken = ToTerm("auto", GrammarNames.AutoToken);
            var beforefieldinitToken = ToTerm("beforefieldinit", GrammarNames.BeforefieldinitToken);
            var beqToken = ToTerm("beq", GrammarNames.BeqToken);
            var beqsToken = new NonTerminal(GrammarNames.BeqsToken);
            beqsToken.Rule = ToTerm("beq") + dot + ToTerm("s");
            var bgeToken = ToTerm("bge", GrammarNames.BgeToken);
            var bgesToken = new NonTerminal(GrammarNames.BgesToken);
            bgesToken.Rule = ToTerm("bge") + dot + ToTerm("s");
            var bgeunToken = new NonTerminal(GrammarNames.BgeunToken);
            bgeunToken.Rule = ToTerm("bge") + dot + ToTerm("un");
            var bgeunsToken = new NonTerminal(GrammarNames.BgeunsToken);
            bgeunsToken.Rule = ToTerm("bge") + dot + ToTerm("un") + dot + ToTerm("s");
            var bgtToken = ToTerm("bgt", GrammarNames.BgtToken);
            var bgtsToken = new NonTerminal(GrammarNames.BgtsToken);
            bgtsToken.Rule = ToTerm("bgt") + dot + ToTerm("s");
            var bgtunToken = new NonTerminal(GrammarNames.BgtunToken);
            bgtunToken.Rule = ToTerm("bgt") + dot + ToTerm("un");
            var bgtunsToken = new NonTerminal(GrammarNames.BgtunsToken);
            bgtunsToken.Rule = ToTerm("bgt") + dot + ToTerm("un") + dot + ToTerm("s");
            var bleToken = ToTerm("ble", GrammarNames.BleToken);
            var blesToken = new NonTerminal(GrammarNames.BlesToken);
            blesToken.Rule = ToTerm("ble") + dot + ToTerm("s");
            var bleunToken = new NonTerminal(GrammarNames.BleunToken);
            bleunToken.Rule = ToTerm("ble") + dot + ToTerm("un");
            var bleunsToken = new NonTerminal(GrammarNames.BleunsToken);
            bleunsToken.Rule = ToTerm("ble") + dot + ToTerm("un") + dot + ToTerm("s");
            var bltToken = ToTerm("blt", GrammarNames.BltToken);
            var bltsToken = new NonTerminal(GrammarNames.BltsToken);
            bltsToken.Rule = ToTerm("blt") + dot + ToTerm("s");
            var bltunToken = new NonTerminal(GrammarNames.BltunToken);
            bltunToken.Rule = ToTerm("blt") + dot + ToTerm("un");
            var bltunsToken = new NonTerminal(GrammarNames.BltunsToken);
            bltunsToken.Rule = ToTerm("blt") + dot + ToTerm("un") + dot + ToTerm("s");
            var bneunToken = new NonTerminal(GrammarNames.BneunToken);
            bneunToken.Rule = ToTerm("bne") + dot + ToTerm("un");
            var bneunsToken = new NonTerminal(GrammarNames.BneunsToken);
            bneunsToken.Rule = ToTerm("bne") + dot + ToTerm("un") + dot + ToTerm("s");
            var boolToken = ToTerm("bool", GrammarNames.BoolToken);
            var brToken = ToTerm("br", GrammarNames.BrToken);
            var brsToken = new NonTerminal(GrammarNames.BrsToken);
            brsToken.Rule = ToTerm("br") + dot + ToTerm("s");
            var brfalseToken = ToTerm("brfalse", GrammarNames.BrfalseToken);
            var brfalsesToken = new NonTerminal(GrammarNames.BrfalsesToken);
            brfalsesToken.Rule = ToTerm("brfalse") + dot + ToTerm("s");
            var brtrueToken = ToTerm("brtrue", GrammarNames.BrtrueToken);
            var brtruesToken = new NonTerminal(GrammarNames.BrtruesToken);
            brtruesToken.Rule = ToTerm("brtrue") + dot + ToTerm("s");
            var callToken = ToTerm("call", GrammarNames.CallToken);
            var callvirtToken = ToTerm("callvirt", GrammarNames.CallvirtToken);
            var ceqToken = ToTerm("ceq", GrammarNames.CeqToken);
            var cgtToken = ToTerm("cgt", GrammarNames.CgtToken);
            var cgtunToken = new NonTerminal(GrammarNames.CgtunToken);
            cgtunToken.Rule = ToTerm("cgt") + dot + ToTerm("un");
            var cilToken = ToTerm("cil", GrammarNames.CilToken);
            var cltToken = ToTerm("clt", GrammarNames.CltToken);
            var cltunToken = new NonTerminal(GrammarNames.CltunToken);
            cltunToken.Rule = ToTerm("clt") + dot + ToTerm("un");
            var divToken = ToTerm("div", GrammarNames.DivToken);
            var divunToken = new NonTerminal(GrammarNames.DivunToken);
            divunToken.Rule = ToTerm("div") + dot + ToTerm("un");
            var dotAssemblyToken = ToTerm(".assembly", GrammarNames.DotAssemblyToken);
            var dotClassToken = ToTerm(".class", GrammarNames.DotClassToken);
            var dotCorflagsToken = ToTerm(".corflags", GrammarNames.DotCorflagsToken);
            var dotCtorToken = ToTerm(".ctor", GrammarNames.DotCtorToken);
            var dotCustomToken = ToTerm(".custom", GrammarNames.DotCustomToken);
            var dotEntrypointToken = ToTerm(".entrypoint", GrammarNames.DotEntrypointToken);
            var dotFileToken = ToTerm(".file", GrammarNames.DotFileToken);
            var dotHashToken = ToTerm(".hash", GrammarNames.DotHashToken);
            var dotImagebaseToken = ToTerm(".imagebase", GrammarNames.DotImagebaseToken);
            var dotLocalsToken = ToTerm(".locals", GrammarNames.DotLocalsToken);
            var dotMaxstackToken = ToTerm(".maxstack", GrammarNames.DotMaxstackToken);
            var dotMethodToken = ToTerm(".method", GrammarNames.DotMethodToken);
            var dotModuleToken = ToTerm(".module", GrammarNames.DotModuleToken);
            var dotPublickeytokenToken = ToTerm(".publickeytoken", GrammarNames.DotPublickeytokenToken);
            var dotStackreserveToken = ToTerm(".stackreserve", GrammarNames.DotStackreserveToken);
            var dotSubsystemToken = ToTerm(".subsystem", GrammarNames.DotSubsystemToken);
            var dotVerToken = ToTerm(".ver", GrammarNames.DotVerToken);
            var dupToken = ToTerm("dup", GrammarNames.DupToken);
            var extendsToken = ToTerm("extends", GrammarNames.ExtendsToken);
            var externToken = ToTerm("extern", GrammarNames.ExternToken);
            var hidebysigToken = ToTerm("hidebysig", GrammarNames.HidebysigToken);
            var initToken = ToTerm("init", GrammarNames.InitToken);
            var instanceToken = ToTerm("instance", GrammarNames.InstanceToken);
            var int32Token = ToTerm("int32", GrammarNames.Int32Token);
            var ldarg0Token = new NonTerminal(GrammarNames.Ldarg0Token);
            ldarg0Token.Rule = ToTerm("ldarg") + dot + ToTerm("0");
            var ldci4Token = new NonTerminal(GrammarNames.Ldci4Token);
            ldci4Token.Rule = ToTerm("ldc") + dot + ToTerm("i4");
            var ldci40Token = new NonTerminal(GrammarNames.Ldci40Token);
            ldci40Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("0");
            var ldci41Token = new NonTerminal(GrammarNames.Ldci41Token);
            ldci41Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("1");
            var ldci42Token = new NonTerminal(GrammarNames.Ldci42Token);
            ldci42Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("2");
            var ldci43Token = new NonTerminal(GrammarNames.Ldci43Token);
            ldci43Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("3");
            var ldci44Token = new NonTerminal(GrammarNames.Ldci44Token);
            ldci44Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("4");
            var ldci45Token = new NonTerminal(GrammarNames.Ldci45Token);
            ldci45Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("5");
            var ldci46Token = new NonTerminal(GrammarNames.Ldci46Token);
            ldci46Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("6");
            var ldci47Token = new NonTerminal(GrammarNames.Ldci47Token);
            ldci47Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("7");
            var ldci48Token = new NonTerminal(GrammarNames.Ldci48Token);
            ldci48Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("8");
            var ldci4m1Token = new NonTerminal(GrammarNames.Ldci4m1Token);
            ldci4m1Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("m1");
            var ldci4M1Token = new NonTerminal(GrammarNames.Ldci4m1AliasToken);
            ldci4M1Token.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("M1");
            var ldci4sToken = new NonTerminal(GrammarNames.Ldci4sToken);
            ldci4sToken.Rule = ToTerm("ldc") + dot + ToTerm("i4") + dot + ToTerm("s");
            var ldloc0Token = new NonTerminal(GrammarNames.Ldloc0Token);
            ldloc0Token.Rule = ToTerm("ldloc") + dot + ToTerm("0");
            var ldloc1Token = new NonTerminal(GrammarNames.Ldloc1Token);
            ldloc1Token.Rule = ToTerm("ldloc") + dot + ToTerm("1");
            var ldloc2Token = new NonTerminal(GrammarNames.Ldloc2Token);
            ldloc2Token.Rule = ToTerm("ldloc") + dot + ToTerm("2");
            var ldloc3Token = new NonTerminal(GrammarNames.Ldloc3Token);
            ldloc3Token.Rule = ToTerm("ldloc") + dot + ToTerm("3");
            var ldstrToken = ToTerm("ldstr", GrammarNames.LdstrToken);
            var leaveToken = ToTerm("leave", GrammarNames.LeaveToken);
            var leavesToken = new NonTerminal(GrammarNames.LeavesToken);
            leavesToken.Rule = ToTerm("leave") + dot + ToTerm("s");
            var managedToken = ToTerm("managed", GrammarNames.ManagedToken);
            var mulToken = ToTerm("mul", GrammarNames.MulToken);
            var mulovfToken = new NonTerminal(GrammarNames.MulovfToken);
            mulovfToken.Rule = ToTerm("mul") + dot + ToTerm("ovf");
            var mulovfunToken = new NonTerminal(GrammarNames.MulovfunToken);
            mulovfunToken.Rule = ToTerm("mul") + dot + ToTerm("ovf") + dot + ToTerm("un");
            var negToken = ToTerm("neg", GrammarNames.NegToken);
            var nopToken = ToTerm("nop", GrammarNames.NopToken);
            var notToken = ToTerm("not", GrammarNames.NotToken);
            var orToken = ToTerm("or", GrammarNames.OrToken);
            var popToken = ToTerm("pop", GrammarNames.PopToken);
            var privateToken = ToTerm("private", GrammarNames.PrivateToken);
            var publicToken = ToTerm("public", GrammarNames.PublicToken);
            var remToken = ToTerm("rem", GrammarNames.RemToken);
            var remunToken = new NonTerminal(GrammarNames.RemunToken);
            remunToken.Rule = ToTerm("rem") + dot + ToTerm("un");
            var retToken = ToTerm("ret", GrammarNames.RetToken);
            var rtspecialnameToken = ToTerm("rtspecialname", GrammarNames.RtspecialnameToken);
            var shlToken = ToTerm("shl", GrammarNames.ShlToken);
            var shrToken = ToTerm("shr", GrammarNames.ShrToken);
            var specialnameToken = ToTerm("specialname", GrammarNames.SpecialnameToken);
            var staticToken = ToTerm("static", GrammarNames.StaticToken);
            var stloc0Token = new NonTerminal(GrammarNames.Stloc0Token);
            stloc0Token.Rule = ToTerm("stloc") + dot + ToTerm("0");
            var stloc1Token = new NonTerminal(GrammarNames.Stloc1Token);
            stloc1Token.Rule = ToTerm("stloc") + dot + ToTerm("1");
            var stloc2Token = new NonTerminal(GrammarNames.Stloc2Token);
            stloc2Token.Rule = ToTerm("stloc") + dot + ToTerm("2");
            var stloc3Token = new NonTerminal(GrammarNames.Stloc3Token);
            stloc3Token.Rule = ToTerm("stloc") + dot + ToTerm("3");
            var stringToken = ToTerm("string", GrammarNames.StringToken);
            var subToken = ToTerm("sub", GrammarNames.SubToken);
            var subovfToken = new NonTerminal(GrammarNames.SubovfToken);
            subovfToken.Rule = ToTerm("sub") + dot + ToTerm("ovf");
            var subovfunToken = new NonTerminal(GrammarNames.SubovfunToken);
            subovfunToken.Rule = ToTerm("sub") + dot + ToTerm("ovf") + dot + ToTerm("un");
            var valuetypeToken = ToTerm("valuetype", GrammarNames.ValuetypeToken);
            var voidToken = ToTerm("void", GrammarNames.VoidToken);
            var xorToken = ToTerm("xor", GrammarNames.XorToken);

            // lexical tokens

            var identifier = new IdentifierTerminal(GrammarNames.Identifier);

            var quotedString = new StringLiteral(GrammarNames.QuotedString, "\"");

            var decInteger = new NumberLiteral(GrammarNames.DecInteger, NumberOptions.IntOnly | NumberOptions.AllowSign);
            var hexInteger = new RegexBasedTerminal(GrammarNames.HexInteger, "0x[A-F0-9]{1,}");

            var integer = new NonTerminal(GrammarNames.Integer);
            integer.Rule =
                decInteger |
                hexInteger;

            var longInteger = new NonTerminal(GrammarNames.LongInteger);
            longInteger.Rule =
                decInteger |
                hexInteger;


            var hexByte = new RegexBasedTerminal(GrammarNames.HexByte, "[A-F0-9]{2}");

            // productions

            var id = new NonTerminal(GrammarNames.Id);
            id.Rule = identifier;

            var name = new NonTerminal(GrammarNames.Name);
            name.Rule =
                id |
                name + dot + name;

            var complexQuotedString = new NonTerminal(GrammarNames.ComplexQuotedString);
            complexQuotedString.Rule =
                quotedString |
                complexQuotedString + plus + quotedString;

            var slashedName = new NonTerminal(GrammarNames.SlashedName);
            slashedName.Rule = name;

            var methodName = new NonTerminal(GrammarNames.MethodName);
            methodName.Rule =
                dotCtorToken |
                name;

            var className = new NonTerminal(GrammarNames.ClassName);
            className.Rule = leftSquareBracket + name + rightSquareBracket + slashedName;

            var hexBytes = new NonTerminal(GrammarNames.HexBytes);
            hexBytes.Rule =
                hexByte |
                hexBytes + hexByte;

            var bytes = new NonTerminal(GrammarNames.Bytes);
            bytes.Rule =
                Empty |
                hexBytes;

            var type = new NonTerminal(GrammarNames.Type);
            type.Rule =
                stringToken |
                valuetypeToken + className |
                type + leftSquareBracket + rightSquareBracket |
                voidToken |
                boolToken |
                int32Token;

            var typeSpecification = new NonTerminal(GrammarNames.TypeSpecification);
            typeSpecification.Rule =
                className |
                leftSquareBracket + name + rightSquareBracket;

            var callKind = new NonTerminal(GrammarNames.CallKind);
            callKind.Rule = Empty;

            var callConventions = new NonTerminal(GrammarNames.CallConventions);
            callConventions.Rule =
                instanceToken + callConventions |
                callKind;

            var paramAttributes = new NonTerminal(GrammarNames.ParamAttributes);
            paramAttributes.Rule =
                Empty |
                paramAttributes + leftSquareBracket + integer + rightSquareBracket;

            var sigArg = new NonTerminal(GrammarNames.SignatureArgument);
            sigArg.Rule =
                paramAttributes + type |
                paramAttributes + type + id;

            var sigArgs1 = new NonTerminal(GrammarNames.SignatureArguments1);
            sigArgs1.Rule =
                sigArg |
                sigArgs1 + comma + sigArg;

            var sigArgs0 = new NonTerminal(GrammarNames.SignatureArguments0);
            sigArgs0.Rule =
                Empty |
                sigArgs1;

            var customType = new NonTerminal(GrammarNames.CustomType);
            customType.Rule =
                callConventions + type + typeSpecification + colon + colon + dotCtorToken + leftParenthesis + sigArgs0 + rightParenthesis |
                callConventions + type + dotCtorToken + leftParenthesis + sigArgs0 + rightParenthesis;

            var customHead = new NonTerminal(GrammarNames.CustomHead);
            customHead.Rule = dotCustomToken + customType + equalsSign + leftParenthesis;

            var customAttributeDeclaration = new NonTerminal(GrammarNames.CustomAttributeDeclaration);
            customAttributeDeclaration.Rule =
                dotCustomToken + customType |
                dotCustomToken + customType + equalsSign + complexQuotedString |
                customHead + bytes + rightParenthesis;

            var instructionNone = new NonTerminal(GrammarNames.InstructionNone);
            instructionNone.Rule =
                addToken |
                addovfToken |
                addovfunToken |
                andToken |
                ceqToken |
                cgtToken |
                cgtunToken |
                cltToken |
                cltunToken |
                divToken |
                divunToken |
                dupToken |
                ldarg0Token |
                ldci40Token |
                ldci41Token |
                ldci42Token |
                ldci43Token |
                ldci44Token |
                ldci45Token |
                ldci46Token |
                ldci47Token |
                ldci48Token |
                ldci4m1Token |
                ldci4M1Token |
                ldloc0Token |
                ldloc1Token |
                ldloc2Token |
                ldloc3Token |
                mulToken |
                mulovfToken |
                mulovfunToken |
                negToken |
                nopToken |
                notToken |
                orToken |
                popToken |
                remToken |
                remunToken |
                retToken |
                shlToken |
                shrToken |
                stloc0Token |
                stloc1Token |
                stloc2Token |
                stloc3Token |
                subToken |
                subovfToken |
                subovfunToken |
                xorToken;

            var instructionBranch = new NonTerminal(GrammarNames.InstructionBranch);
            instructionBranch.Rule =
                beqToken |
                beqsToken |
                bgeToken |
                bgesToken |
                bgeunToken |
                bgeunsToken |
                bgtToken |
                bgtsToken |
                bgtunToken |
                bgtunsToken |
                bleToken |
                blesToken |
                bleunToken |
                bleunsToken |
                bltToken |
                bltsToken |
                bltunToken |
                bltunsToken |
                bneunToken |
                bneunsToken |
                brToken |
                brsToken |
                brfalseToken |
                brfalsesToken |
                brtrueToken |
                brtruesToken |
                leaveToken |
                leavesToken;

            var instructionInt = new NonTerminal(GrammarNames.InstructionInt);
            instructionInt.Rule =
                ldci4Token |
                ldci4sToken;

            var instructionMethod = new NonTerminal(GrammarNames.InstructionMethod);
            instructionMethod.Rule =
                callToken |
                callvirtToken;

            var instructionString = new NonTerminal(GrammarNames.InstructionString);
            instructionString.Rule = ldstrToken;

            var instruction = new NonTerminal(GrammarNames.Instruction);
            instruction.Rule =
                instructionBranch + integer |
                instructionBranch + identifier |
                instructionInt + integer |
                instructionNone |
                instructionMethod + callConventions + type + typeSpecification + colon + colon + methodName + leftParenthesis + sigArgs0 + rightParenthesis |
                instructionMethod + callConventions + type + methodName + leftParenthesis + sigArgs0 + rightParenthesis |
                instructionString + complexQuotedString;

            var implementationAttributes = new NonTerminal(GrammarNames.ImplementationAttributes);
            implementationAttributes.Rule =
                Empty |
                implementationAttributes + cilToken |
                implementationAttributes + managedToken;

            var localsHead = new NonTerminal(GrammarNames.LocalsHead);
            localsHead.Rule = dotLocalsToken;

            var methodAttributes = new NonTerminal(GrammarNames.MethodAttributes);
            methodAttributes.Rule =
                Empty |
                methodAttributes + staticToken |
                methodAttributes + publicToken |
                methodAttributes + privateToken |
                methodAttributes + specialnameToken |
                methodAttributes + hidebysigToken |
                methodAttributes + rtspecialnameToken;

            var methodHead = new NonTerminal(GrammarNames.MethodHead);
            methodHead.Rule = dotMethodToken + methodAttributes + callConventions + paramAttributes + type + methodName + leftParenthesis + sigArgs0 + rightParenthesis + implementationAttributes + leftBrace;

            var methodDeclaration = new NonTerminal(GrammarNames.MethodDeclaration);
            methodDeclaration.Rule =
                dotMaxstackToken + integer |
                localsHead + leftParenthesis + sigArgs0 + rightParenthesis |
                localsHead + initToken + leftParenthesis + sigArgs0 + rightParenthesis |
                dotEntrypointToken |
                instruction |
                id + colon;

            var methodDeclarations = new NonTerminal(GrammarNames.MethodDeclarations);
            methodDeclarations.Rule =
                Empty |
                methodDeclarations + methodDeclaration;

            var extendsClause = new NonTerminal(GrammarNames.ExtendsClause);
            extendsClause.Rule =
                Empty |
                extendsToken + className;

            var implementsClause = new NonTerminal(GrammarNames.ImplementsClause);
            implementsClause.Rule = Empty;

            var publicKeyTokenHead = new NonTerminal(GrammarNames.PublicKeyTokenHead);
            publicKeyTokenHead.Rule = dotPublickeytokenToken + equalsSign + leftParenthesis;

            var classAttributes = new NonTerminal(GrammarNames.ClassAttributes);
            classAttributes.Rule =
                Empty |
                classAttributes + privateToken |
                classAttributes + autoToken |
                classAttributes + ansiToken |
                classAttributes + beforefieldinitToken;

            var classHead = new NonTerminal(GrammarNames.ClassHead);
            classHead.Rule = dotClassToken + classAttributes + name + extendsClause + implementsClause;

            var classDeclaration = new NonTerminal(GrammarNames.ClassDeclaration);
            classDeclaration.Rule = methodHead + methodDeclarations + rightBrace;

            var classDeclarations = new NonTerminal(GrammarNames.ClassDeclarations);
            classDeclarations.Rule =
                Empty |
                classDeclarations + classDeclaration;

            var assemblyAttributes = new NonTerminal(GrammarNames.AssemblyAttributes);
            assemblyAttributes.Rule = Empty;

            var assemblyOrRefDeclaration = new NonTerminal(GrammarNames.AssemblyOrRefDeclaration);
            assemblyOrRefDeclaration.Rule =
                dotVerToken + integer + colon + integer + colon + integer + colon + integer |
                customAttributeDeclaration;

            var assemblyHead = new NonTerminal(GrammarNames.AssemblyHead);
            assemblyHead.Rule = dotAssemblyToken + assemblyAttributes + name;

            var assemblyDeclaration = new NonTerminal(GrammarNames.AssemblyDeclaration);
            assemblyDeclaration.Rule =
                dotHashToken + algorithmToken + integer |
                assemblyOrRefDeclaration;

            var assemblyDeclarations = new NonTerminal(GrammarNames.AssemblyDeclarations);
            assemblyDeclarations.Rule =
                Empty |
                assemblyDeclarations + assemblyDeclaration;

            var assemblyRefHead = new NonTerminal(GrammarNames.AssemblyRefHead);
            assemblyRefHead.Rule = dotAssemblyToken + externToken + name;

            var assemblyRefDeclaration = new NonTerminal(GrammarNames.AssemblyRefDeclaration);
            assemblyRefDeclaration.Rule =
                assemblyOrRefDeclaration |
                publicKeyTokenHead + bytes + rightParenthesis;

            var assemblyRefDeclarations = new NonTerminal(GrammarNames.AssemblyRefDeclarations);
            assemblyRefDeclarations.Rule =
                Empty |
                assemblyRefDeclarations + assemblyRefDeclaration;

            var moduleHead = new NonTerminal(GrammarNames.ModuleHead);
            moduleHead.Rule = dotModuleToken + name;

            var declaration = new NonTerminal(GrammarNames.Declaration);
            declaration.Rule =
                classHead + leftBrace + classDeclarations + rightBrace |
                assemblyHead + leftBrace + assemblyDeclarations + rightBrace |
                assemblyRefHead + leftBrace + assemblyRefDeclarations + rightBrace |
                moduleHead |
                dotSubsystemToken + integer |
                dotCorflagsToken + integer |
                dotFileToken + alignmentToken + integer |
                dotImagebaseToken + longInteger |
                dotStackreserveToken + integer;

            var declarations = new NonTerminal(GrammarNames.Declarations);
            declarations.Rule =
                Empty |
                declarations + declaration;

            Root = declarations;
        }
    }
}