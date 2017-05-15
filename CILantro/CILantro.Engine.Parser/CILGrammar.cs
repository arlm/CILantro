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
            var addovfToken = ToTerm("add.ovf", GrammarNames.AddovfToken);
            var addovfunToken = ToTerm("add.ovf.un", GrammarNames.AddovfunToken);
            var algorithmToken = ToTerm("algorithm", GrammarNames.AlgorithmToken);
            var alignmentToken = ToTerm("alignment", GrammarNames.AlignmentToken);
            var andToken = ToTerm("and", GrammarNames.AndToken);
            var ansiToken = ToTerm("ansi", GrammarNames.AnsiToken);
            var autoToken = ToTerm("auto", GrammarNames.AutoToken);
            var beforefieldinitToken = ToTerm("beforefieldinit", GrammarNames.BeforefieldinitToken);
            var beqToken = ToTerm("beq", GrammarNames.BeqToken);
            var beqsToken = ToTerm("beq.s", GrammarNames.BeqsToken);
            var bgeToken = ToTerm("bge", GrammarNames.BgeToken);
            var bgesToken = ToTerm("bge.s", GrammarNames.BgesToken);
            var bgeunToken = ToTerm("bge.un", GrammarNames.BgeunToken);
            var bgeunsToken = ToTerm("bge.un.s", GrammarNames.BgeunsToken);
            var bgtToken = ToTerm("bgt", GrammarNames.BgtToken);
            var bgtsToken = ToTerm("bgt.s", GrammarNames.BgtsToken);
            var bgtunToken = ToTerm("bgt.un", GrammarNames.BgtunToken);
            var bgtunsToken = ToTerm("bgt.un.s", GrammarNames.BgtunsToken);
            var bleToken = ToTerm("ble", GrammarNames.BleToken);
            var blesToken = ToTerm("ble.s", GrammarNames.BlesToken);
            var bleunToken = ToTerm("ble.un", GrammarNames.BleunToken);
            var bleunsToken = ToTerm("ble.un.s", GrammarNames.BleunsToken);
            var bltToken = ToTerm("blt", GrammarNames.BltToken);
            var bltsToken = ToTerm("blt.s", GrammarNames.BltsToken);
            var bltunToken = ToTerm("blt.un", GrammarNames.BltunToken);
            var bltunsToken = ToTerm("blt.un.s", GrammarNames.BltunsToken);
            var bneunToken = ToTerm("bne.un", GrammarNames.BneunToken);
            var bneunsToken = ToTerm("bne.un.s", GrammarNames.BneunsToken);
            var boolToken = ToTerm("bool", GrammarNames.BoolToken);
            var brToken = ToTerm("br", GrammarNames.BrToken);
            var brsToken = ToTerm("br.s", GrammarNames.BrsToken);
            var brfalseToken = ToTerm("brfalse", GrammarNames.BrfalseToken);
            var brfalsesToken = ToTerm("brfalse.s", GrammarNames.BrfalsesToken);
            var brtrueToken = ToTerm("brtrue", GrammarNames.BrtrueToken);
            var brtruesToken = ToTerm("brtrue.s", GrammarNames.BrtruesToken);
            var callToken = ToTerm("call", GrammarNames.CallToken);
            var ceqToken = ToTerm("ceq", GrammarNames.CeqToken);
            var cgtToken = ToTerm("cgt", GrammarNames.CgtToken);
            var cgtunToken = ToTerm("cgt.un", GrammarNames.CgtunToken);
            var cilToken = ToTerm("cil", GrammarNames.CilToken);
            var cltToken = ToTerm("clt", GrammarNames.CltToken);
            var cltunToken = ToTerm("clt.un", GrammarNames.CltunToken);
            var ctorToken = ToTerm(".ctor", GrammarNames.CtorToken);
            var customToken = ToTerm(".custom", GrammarNames.CustomToken);
            var divToken = ToTerm("div", GrammarNames.DivToken);
            var divunToken = ToTerm("div.un", GrammarNames.DivunToken);
            var dotAssemblyToken = ToTerm(".assembly", GrammarNames.DotAssemblyToken);
            var dotClassToken = ToTerm(".class", GrammarNames.DotClassToken);
            var dotCorflagsToken = ToTerm(".corflags", GrammarNames.DotCorflagsToken);
            var dotCtorToken = ToTerm(".ctor", GrammarNames.DotCtorToken);
            var dotEntrypointToken = ToTerm(".entrypoint", GrammarNames.DotEntrypointToken);
            var dotFileToken = ToTerm(".file", GrammarNames.DotFileToken);
            var dotImagebaseToken = ToTerm(".imagebase", GrammarNames.DotImagebaseToken);
            var dotMaxstackToken = ToTerm(".maxstack", GrammarNames.DotMaxstackToken);
            var dotMethodToken = ToTerm(".method", GrammarNames.DotMethodToken);
            var dotModuleToken = ToTerm(".module", GrammarNames.DotModuleToken);
            var dotStackreserveToken = ToTerm(".stackreserve", GrammarNames.DotStackreserveToken);
            var dotSubsystemToken = ToTerm(".subsystem", GrammarNames.DotSubsystemToken);
            var dupToken = ToTerm("dup", GrammarNames.DupToken);
            var extendsToken = ToTerm("extends", GrammarNames.ExtendsToken);
            var externToken = ToTerm("extern", GrammarNames.ExternToken);
            var hashToken = ToTerm(".hash", GrammarNames.HashToken);
            var hidebysigToken = ToTerm("hidebysig", GrammarNames.HidebysigToken);
            var instanceToken = ToTerm("instance", GrammarNames.InstanceToken);
            var int32Token = ToTerm("int32", GrammarNames.Int32Token);
            var ldarg0Token = new NonTerminal(GrammarNames.Ldarg0Token);
            ldarg0Token.Rule = ToTerm("ldarg") + dot + ToTerm("0");
            var ldci4Token = ToTerm("ldc.i4", GrammarNames.Ldci4Token);
            var ldci40Token = ToTerm("ldc.i4.0", GrammarNames.Ldci40Token);
            var ldci41Token = ToTerm("ldc.i4.1", GrammarNames.Ldci41Token);
            var ldci42Token = ToTerm("ldc.i4.2", GrammarNames.Ldci42Token);
            var ldci43Token = ToTerm("ldc.i4.3", GrammarNames.Ldci43Token);
            var ldci44Token = ToTerm("ldc.i4.4", GrammarNames.Ldci44Token);
            var ldci45Token = ToTerm("ldc.i4.5", GrammarNames.Ldci45Token);
            var ldci46Token = ToTerm("ldc.i4.6", GrammarNames.Ldci46Token);
            var ldci47Token = ToTerm("ldc.i4.7", GrammarNames.Ldci47Token);
            var ldci48Token = ToTerm("ldc.i4.8", GrammarNames.Ldci48Token);
            var ldci4m1Token = ToTerm("ldc.i4.m1", GrammarNames.Ldci4m1Token);
            var ldci4M1Token = ToTerm("ldc.i4.M1", GrammarNames.Ldci4m1AliasToken);
            var ldci4sToken = ToTerm("ldc.i4.s", GrammarNames.Ldci4sToken);
            var ldstrToken = ToTerm("ldstr", GrammarNames.LdstrToken);
            var leaveToken = ToTerm("leave", GrammarNames.LeaveToken);
            var leavesToken = ToTerm("leave.s", GrammarNames.LeavesToken);
            var managedToken = ToTerm("managed", GrammarNames.ManagedToken);
            var mulToken = ToTerm("mul", GrammarNames.MulToken);
            var mulovfToken = ToTerm("mul.ovf", GrammarNames.MulovfToken);
            var mulovfunToken = ToTerm("mul.ovf.un", GrammarNames.MulovfunToken);
            var negToken = ToTerm("neg", GrammarNames.NegToken);
            var nopToken = ToTerm("nop", GrammarNames.NopToken);
            var notToken = ToTerm("not", GrammarNames.NotToken);
            var orToken = ToTerm("or", GrammarNames.OrToken);
            var popToken = ToTerm("pop", GrammarNames.PopToken);
            var privateToken = ToTerm("private", GrammarNames.PrivateToken);
            var publicToken = ToTerm("public", GrammarNames.PublicToken);
            var publickeytokenToken = ToTerm(".publickeytoken", GrammarNames.PublickeytokenToken);
            var retToken = ToTerm("ret", GrammarNames.RetToken);
            var rtspecialnameToken = ToTerm("rtspecialname", GrammarNames.RtspecialnameToken);
            var shlToken = ToTerm("shl", GrammarNames.ShlToken);
            var shrToken = ToTerm("shr", GrammarNames.ShrToken);
            var specialnameToken = ToTerm("specialname", GrammarNames.SpecialnameToken);
            var staticToken = ToTerm("static", GrammarNames.StaticToken);
            var stringToken = ToTerm("string", GrammarNames.StringToken);
            var subToken = ToTerm("sub", GrammarNames.SubToken);
            var subovfToken = ToTerm("sub.ovf", GrammarNames.SubovfToken);
            var subovfunToken = ToTerm("sub.ovf.un", GrammarNames.SubovfunToken);
            var valuetypeToken = ToTerm("valuetype", GrammarNames.ValuetypeToken);
            var verToken = ToTerm(".ver", GrammarNames.VerToken);
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
            paramAttributes.Rule = Empty;

            var signatureArgument = new NonTerminal(GrammarNames.SignatureArgument);
            signatureArgument.Rule =
                paramAttributes + type |
                paramAttributes + type + id;

            var signatureArguments1 = new NonTerminal(GrammarNames.SignatureArguments1);
            signatureArguments1.Rule =
                signatureArgument |
                signatureArguments1 + comma + signatureArgument;

            var signatureArguments0 = new NonTerminal(GrammarNames.SignatureArguments0);
            signatureArguments0.Rule =
                Empty |
                signatureArguments1;

            var customType = new NonTerminal(GrammarNames.CustomType);
            customType.Rule =
                callConventions + type + typeSpecification + colon + colon + ctorToken + leftParenthesis + signatureArguments0 + rightParenthesis |
                callConventions + type + ctorToken + leftParenthesis + signatureArguments0 + rightParenthesis;

            var customHead = new NonTerminal(GrammarNames.CustomHead);
            customHead.Rule = customToken + customType + equalsSign + leftParenthesis;

            var customAttributeDeclaration = new NonTerminal(GrammarNames.CustomAttributeDeclaration);
            customAttributeDeclaration.Rule =
                customToken + customType |
                customToken + customType + equalsSign + complexQuotedString |
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
                mulToken |
                mulovfToken |
                mulovfunToken |
                negToken |
                nopToken |
                notToken |
                orToken |
                popToken |
                retToken |
                shlToken |
                shrToken |
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
            instructionMethod.Rule = callToken;

            var instructionString = new NonTerminal(GrammarNames.InstructionString);
            instructionString.Rule = ldstrToken;

            var instruction = new NonTerminal(GrammarNames.Instruction);
            instruction.Rule =
                instructionBranch + integer |
                instructionInt + integer |
                instructionNone |
                instructionMethod + callConventions + type + typeSpecification + colon + colon + methodName + leftParenthesis + signatureArguments0 + rightParenthesis |
                instructionMethod + callConventions + type + methodName + leftParenthesis + signatureArguments0 + rightParenthesis |
                instructionString + complexQuotedString;

            var implementationAttributes = new NonTerminal(GrammarNames.ImplementationAttributes);
            implementationAttributes.Rule =
                Empty |
                implementationAttributes + cilToken |
                implementationAttributes + managedToken;

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
            methodHead.Rule = dotMethodToken + methodAttributes + callConventions + paramAttributes + type + methodName + leftParenthesis + signatureArguments0 + rightParenthesis + implementationAttributes + leftBrace;

            var methodDeclaration = new NonTerminal(GrammarNames.MethodDeclaration);
            methodDeclaration.Rule =
                dotMaxstackToken + integer |
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
            publicKeyTokenHead.Rule = publickeytokenToken + equalsSign + leftParenthesis;

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
                verToken + integer + colon + integer + colon + integer + colon + integer |
                customAttributeDeclaration;

            var assemblyHead = new NonTerminal(GrammarNames.AssemblyHead);
            assemblyHead.Rule = dotAssemblyToken + assemblyAttributes + name;

            var assemblyDeclaration = new NonTerminal(GrammarNames.AssemblyDeclaration);
            assemblyDeclaration.Rule =
                hashToken + algorithmToken + integer |
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
