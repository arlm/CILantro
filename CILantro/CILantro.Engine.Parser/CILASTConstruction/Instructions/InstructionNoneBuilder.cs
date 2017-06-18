﻿using CILantro.Engine.AST.ASTNodes.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionNoneBuilder : CILASTNodeBuilder<InstructionNone>
    {
        public override InstructionNone BuildNode(ParseTreeNode node)
        {
            var instructionNoneNode = node.GetChildInstructionNoneNode();

            var addToken = instructionNoneNode.GetChildAddTokenNode();
            if (addToken != null)
                return new AddInstruction();

            var addovfToken = instructionNoneNode.GetChildAddovfTokenNode();
            if (addovfToken != null)
                return new AddOverflowInstruction();

            var addovfunToken = instructionNoneNode.GetChildAddovfunTokenNode();
            if (addovfunToken != null)
                return new AddOverflowUnsignedInstruction();

            var andToken = instructionNoneNode.GetChildAndTokenNode();
            if (andToken != null)
                return new AndInstruction();

            var ceqToken = instructionNoneNode.GetChildCeqTokenNode();
            if (ceqToken != null)
                return new CheckIfEqualInstruction();

            var cgtToken = instructionNoneNode.GetChildCgtTokenNode();
            if (cgtToken != null)
                return new CheckIfGreaterInstruction();

            var cgtunToken = instructionNoneNode.GetChildCgtunTokenNode();
            if (cgtunToken != null)
                return new CheckIfGreaterUnsignedInstruction();

            var cltToken = instructionNoneNode.GetChildCltTokenNode();
            if (cltToken != null)
                return new CheckIfLessInstruction();

            var cltunToken = instructionNoneNode.GetChildCltunTokenNode();
            if (cltunToken != null)
                return new CheckIfLessUnsignedInstruction();

            var divToken = instructionNoneNode.GetChildDivTokenNode();
            if (divToken != null)
                return new DivideInstruction();

            var divunToken = instructionNoneNode.GetChildDivunTokenNode();
            if (divunToken != null)
                return new DivideUnsignedInstruction();

            var dupToken = instructionNoneNode.GetChildDupTokenNode();
            if (dupToken != null)
                return new DuplicateInstruction();

            var ldarg0Token = instructionNoneNode.GetChildLdarg0TokenNode();
            if (ldarg0Token != null)
                return new LoadArgument0Instruction();

            var ldci40Token = instructionNoneNode.GetChildLdci40TokenNode();
            if (ldci40Token != null)
                return new LoadConstantInt0Instruction();

            var ldci41Token = instructionNoneNode.GetChildLdci41TokenNode();
            if (ldci41Token != null)
                return new LoadConstantInt1Instruction();

            var ldci42Token = instructionNoneNode.GetChildLdci42TokenNode();
            if (ldci42Token != null)
                return new LoadConstantInt2Instruction();

            var ldci43Token = instructionNoneNode.GetChildLdci43TokenNode();
            if (ldci43Token != null)
                return new LoadConstantInt3Instruction();

            var ldci44Token = instructionNoneNode.GetChildLdci44TokenNode();
            if (ldci44Token != null)
                return new LoadConstantInt4Instruction();

            var ldci45Token = instructionNoneNode.GetChildLdci45TokenNode();
            if (ldci45Token != null)
                return new LoadConstantInt5Instruction();

            var ldci46Token = instructionNoneNode.GetChildLdci46TokenNode();
            if (ldci46Token != null)
                return new LoadConstantInt6Instruction();

            var ldci47Token = instructionNoneNode.GetChildLdci47TokenNode();
            if (ldci47Token != null)
                return new LoadConstantInt7Instruction();

            var ldci48Token = instructionNoneNode.GetChildLdci48TokenNode();
            if (ldci48Token != null)
                return new LoadConstantInt8Instruction();

            var ldci4m1Token = instructionNoneNode.GetChildLdci4m1TokenNode();
            var ldci4m1AliasToken = instructionNoneNode.GetChildLdci4m1AliasTokenNode();
            if (ldci4m1Token != null || ldci4m1AliasToken != null)
                return new LoadConstantIntMinus1Instruction();

            var ldloc0Token = instructionNoneNode.GetChildLdloc0TokenNode();
            if (ldloc0Token != null)
                return new LoadLocalVariable0Instruction();

            var ldloc1Token = instructionNoneNode.GetChildLdloc1TokenNode();
            if (ldloc1Token != null)
                return new LoadLocalVariable1Instruction();

            var ldloc2Token = instructionNoneNode.GetChildLdloc2TokenNode();
            if (ldloc2Token != null)
                return new LoadLocalVariable2Instruction();

            var ldloc3Token = instructionNoneNode.GetChildLdloc3TokenNode();
            if (ldloc3Token != null)
                return new LoadLocalVariable3Instruction();

            var mulTokenNode = instructionNoneNode.GetChildMulTokenNode();
            if (mulTokenNode != null)
                return new MultipleInstruction();

            var mulovfTokenNode = instructionNoneNode.GetChildMulovfTokenNode();
            if (mulovfTokenNode != null)
                return new MultipleOverflowInstruction();

            var mulovfunTokenNode = instructionNoneNode.GetChildMulovfunTokenNode();
            if (mulovfunTokenNode != null)
                return new MultipleOverflowUnsignedInstruction();

            var negTokenNode = instructionNoneNode.GetChildNegTokenNode();
            if (negTokenNode != null)
                return new NegateInstruction();

            var nopTokenNode = instructionNoneNode.GetChildNopTokenNode();
            if (nopTokenNode != null)
                return new NoOperationInstruction();

            var notTokenNode = instructionNoneNode.GetChildNotTokenNode();
            if (notTokenNode != null)
                return new ComplementInstruction();

            var orTokenNode = instructionNoneNode.GetChildOrTokenNode();
            if (orTokenNode != null)
                return new OrInstruction();

            var popTokenNode = instructionNoneNode.GetChildPopTokenNode();
            if (popTokenNode != null)
                return new PopInstruction();

            var remTokenNode = instructionNoneNode.GetChildRemTokenNode();
            if (remTokenNode != null)
                return new RemainderInstruction();

            var remunTokenNode = instructionNoneNode.GetChildRemunTokenNode();
            if (remTokenNode != null)
                return new RemainderUnsignedInstruction();

            var retTokenNode = instructionNoneNode.GetChildRetTokenNode();
            if (retTokenNode != null)
                return new RetInstruction();

            var shlTokenNode = instructionNoneNode.GetChildShlTokenNode();
            if (shlTokenNode != null)
                return new ShiftLeftInstruction();

            var shrTokenNode = instructionNoneNode.GetChildShrTokenNode();
            if (shrTokenNode != null)
                return new ShiftRightInstruction();

            var stloc0TokenNode = instructionNoneNode.GetChildStloc0TokenNode();
            if (stloc0TokenNode != null)
                return new SetLocalVariable0Instruction();

            var stloc1TokenNode = instructionNoneNode.GetChildStloc1TokenNode();
            if (stloc1TokenNode != null)
                return new SetLocalVariable1Instruction();

            var stloc2TokenNode = instructionNoneNode.GetChildStloc2TokenNode();
            if (stloc2TokenNode != null)
                return new SetLocalVariable2Instruction();

            var stloc3TokenNode = instructionNoneNode.GetChildStloc3TokenNode();
            if (stloc3TokenNode != null)
                return new SetLocalVariable3Instruction();

            var subTokenNode = instructionNoneNode.GetChildSubTokenNode();
            if (subTokenNode != null)
                return new SubtractInstruction();

            var subovfTokenNode = instructionNoneNode.GetChildSubovfTokenNode();
            if (subovfTokenNode != null)
                return new SubtractOverflowInstruction();

            var subovfunTokenNode = instructionNoneNode.GetChildSubovfunTokenNode();
            if (subovfunTokenNode != null)
                return new SubtractOverflowUnsignedInstruction();

            var xorTokenNode = instructionNoneNode.GetChildXorTokenNode();
            if (xorTokenNode != null)
                return new XorInstruction();

            throw new ArgumentException("Cannot recognize instruction none.");
        }
    }
}