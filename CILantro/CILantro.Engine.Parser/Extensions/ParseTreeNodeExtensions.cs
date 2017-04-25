﻿using Irony.Parsing;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.Engine.Parser.Extensions
{
    public static class ParseTreeNodeExtensions
    {
        public static bool IsAddTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.AddToken);
        public static bool IsAddovfTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.AddovfToken);
        public static bool IsAddovfunTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.AddovfunToken);
        public static bool IsBeqTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BeqToken);
        public static bool IsBeqsTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BeqsToken);
        public static bool IsBgeTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BgeToken);
        public static bool IsBgesTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BgesToken);
        public static bool IsBgeunTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BgeunToken);
        public static bool IsBgeunsTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BgeunsToken);
        public static bool IsBgtTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BgtToken);
        public static bool IsBgtsTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BgtsToken);
        public static bool IsBgtunTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BgtunToken);
        public static bool IsBgtunsTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BgtunsToken);
        public static bool IsBleTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BleToken);
        public static bool IsBlesTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BlesToken);
        public static bool IsBleunTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BleunToken);
        public static bool IsBleunsTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BleunsToken);
        public static bool IsBltTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BltToken);
        public static bool IsBltsTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BltsToken);
        public static bool IsBltunTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BltunToken);
        public static bool IsBltunsTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BltunsToken);
        public static bool IsBneunTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BneunToken);
        public static bool IsBneunsTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BneunsToken);
        public static bool IsBrTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BrToken);
        public static bool IsBrsTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BrsToken);
        public static bool IsBrfalseTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BrfalseToken);
        public static bool IsBrfalsesTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BrfalsesToken);
        public static bool IsBrtrueTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BrtrueToken);
        public static bool IsBrtruesTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.BrtruesToken);
        public static bool IsClassDeclarationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ClassDeclaration);
        public static bool IsClassDeclarationsNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ClassDeclarations);
        public static bool IsClassHeadDeclarationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ClassHead);
        public static bool IsClassNameNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ClassName);
        public static bool IsComplexQuotedStringNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ComplexQuotedString);
        public static bool IsDeclarationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Declaration);
        public static bool IsDupTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.DupToken);
        public static bool IsIdNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Id);
        public static bool IsInstructionNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Instruction);
        public static bool IsInstructionBranchNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.InstructionBranch);
        public static bool IsInstructionIntNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.InstructionInt);
        public static bool IsInstructionMethodNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.InstructionMethod);
        public static bool IsInstructionStringNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.InstructionString);
        public static bool IsInstructionNoneNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.InstructionNone);
        public static bool IsIntegerNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Integer);
        public static bool IsLdci4TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci4Token);
        public static bool IsLdci40TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci40Token);
        public static bool IsLdci41TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci41Token);
        public static bool IsLdci42TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci42Token);
        public static bool IsLdci43TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci43Token);
        public static bool IsLdci44TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci44Token);
        public static bool IsLdci45TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci45Token);
        public static bool IsLdci46TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci46Token);
        public static bool IsLdci47TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci47Token);
        public static bool IsLdci48TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci48Token);
        public static bool IsLdci4m1TokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci4m1Token);
        public static bool IsLdci4m1AliasTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci4m1AliasToken);
        public static bool IsLdci4sTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Ldci4sToken);
        public static bool IsLeaveTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.LeaveToken);
        public static bool IsLeavesTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.LeavesToken);
        public static bool IsMethodDeclarationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.MethodDeclaration);
        public static bool IsMethodDeclarationsNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.MethodDeclarations);
        public static bool IsMethodNameNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.MethodName);
        public static bool IsNameNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Name);
        public static bool IsPopTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.PopToken);
        public static bool IsQuotedStringNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.QuotedString);
        public static bool IsRetTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.RetToken);
        public static bool IsSignatureArgumentNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.SignatureArgument);
        public static bool IsSignatureArguments0Node(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.SignatureArguments0);
        public static bool IsSignatureArguments1Node(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.SignatureArguments1);
        public static bool IsSlashedNameNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.SlashedName);
        public static bool IsTypeNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Type);
        public static bool IsTypeSpecificationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.TypeSpecification);

        public static ParseTreeNode GetChildAddTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsAddTokenNode());
        public static ParseTreeNode GetChildAddovfTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsAddovfTokenNode());
        public static ParseTreeNode GetChildAddovfunTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsAddovfunTokenNode());
        public static ParseTreeNode GetChildBeqTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBeqTokenNode());
        public static ParseTreeNode GetChildBeqsTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBeqsTokenNode());
        public static ParseTreeNode GetChildBgeTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBgeTokenNode());
        public static ParseTreeNode GetChildBgesTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBgesTokenNode());
        public static ParseTreeNode GetChildBgeunTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBgeunTokenNode());
        public static ParseTreeNode GetChildBgeunsTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBgeunsTokenNode());
        public static ParseTreeNode GetChildBgtTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBgtTokenNode());
        public static ParseTreeNode GetChildBgtsTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBgtsTokenNode());
        public static ParseTreeNode GetChildBgtunTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBgtunTokenNode());
        public static ParseTreeNode GetChildBgtunsTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBgtunsTokenNode());
        public static ParseTreeNode GetChildBleTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBleTokenNode());
        public static ParseTreeNode GetChildBlesTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBlesTokenNode());
        public static ParseTreeNode GetChildBleunTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBleunTokenNode());
        public static ParseTreeNode GetChildBleunsTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBleunsTokenNode());
        public static ParseTreeNode GetChildBltTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBltTokenNode());
        public static ParseTreeNode GetChildBltsTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBltsTokenNode());
        public static ParseTreeNode GetChildBltunTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBltunTokenNode());
        public static ParseTreeNode GetChildBltunsTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBltunsTokenNode());
        public static ParseTreeNode GetChildBneunTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBneunTokenNode());
        public static ParseTreeNode GetChildBneunsTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBneunsTokenNode());
        public static ParseTreeNode GetChildBrTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBrTokenNode());
        public static ParseTreeNode GetChildBrsTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBrsTokenNode());
        public static ParseTreeNode GetChildBrfalseTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBrfalseTokenNode());
        public static ParseTreeNode GetChildBrfalsesTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBrfalsesTokenNode());
        public static ParseTreeNode GetChildBrtrueTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBrtrueTokenNode());
        public static ParseTreeNode GetChildBrtruesTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsBrtruesTokenNode());
        public static ParseTreeNode GetChildClassDeclarationNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsClassDeclarationNode());
        public static ParseTreeNode GetChildClassDeclarationsNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsClassDeclarationsNode());
        public static ParseTreeNode GetChildClassHeadNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsClassHeadDeclarationNode());
        public static ParseTreeNode GetChildClassNameNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsClassNameNode());
        public static ParseTreeNode GetChildComplexQuotedStringNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsComplexQuotedStringNode());
        public static ParseTreeNode GetChildDeclarationNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsDeclarationNode());
        public static ParseTreeNode GetChildDupTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsDupTokenNode());
        public static ParseTreeNode GetChildIdNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsIdNode());
        public static ParseTreeNode GetChildInstructionNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionNode());
        public static ParseTreeNode GetChildInstructionBranchNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionBranchNode());
        public static ParseTreeNode GetChildInstructionIntNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionIntNode());
        public static ParseTreeNode GetChildInstructionMethodNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionMethodNode());
        public static ParseTreeNode GetChildInstructionStringNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionStringNode());
        public static ParseTreeNode GetChildInstructionNoneNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionNoneNode());
        public static ParseTreeNode GetChildIntegerNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsIntegerNode());
        public static ParseTreeNode GetChildLdci4TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci4TokenNode());
        public static ParseTreeNode GetChildLdci40TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci40TokenNode());
        public static ParseTreeNode GetChildLdci41TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci41TokenNode());
        public static ParseTreeNode GetChildLdci42TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci42TokenNode());
        public static ParseTreeNode GetChildLdci43TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci43TokenNode());
        public static ParseTreeNode GetChildLdci44TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci44TokenNode());
        public static ParseTreeNode GetChildLdci45TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci45TokenNode());
        public static ParseTreeNode GetChildLdci46TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci46TokenNode());
        public static ParseTreeNode GetChildLdci47TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci47TokenNode());
        public static ParseTreeNode GetChildLdci48TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci48TokenNode());
        public static ParseTreeNode GetChildLdci4m1TokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci4m1TokenNode());
        public static ParseTreeNode GetChildLdci4m1AliasTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci4m1AliasTokenNode());
        public static ParseTreeNode GetChildLdci4sTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLdci4sTokenNode());
        public static ParseTreeNode GetChildLeaveTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLeaveTokenNode());
        public static ParseTreeNode GetChildLeavesTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsLeavesTokenNode());
        public static ParseTreeNode GetChildMethodDeclarationNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsMethodDeclarationNode());
        public static ParseTreeNode GetChildMethodDeclarationsNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsMethodDeclarationsNode());
        public static ParseTreeNode GetChildMethodNameNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsMethodNameNode());
        public static ParseTreeNode GetChildNameNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsNameNode());
        public static ParseTreeNode GetChildPopTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsPopTokenNode());
        public static ParseTreeNode GetChildQuotedStringNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsQuotedStringNode());
        public static ParseTreeNode GetChildRetTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsRetTokenNode());
        public static ParseTreeNode GetChildSignatureArgumentNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsSignatureArgumentNode());
        public static ParseTreeNode GetChildSignatureArguments0Node(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsSignatureArguments0Node());
        public static ParseTreeNode GetChildSignatureArguments1Node(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsSignatureArguments1Node());
        public static ParseTreeNode GetChildSlashedNameNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsSlashedNameNode());
        public static ParseTreeNode GetChildTypeNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsTypeNode());
        public static ParseTreeNode GetChildTypeSpecificationNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsTypeSpecificationNode());

        public static IEnumerable<ParseTreeNode> GetAllChildNameNodes(this ParseTreeNode node) => node.ChildNodes.Where(cn => cn.IsNameNode());
    }
}
