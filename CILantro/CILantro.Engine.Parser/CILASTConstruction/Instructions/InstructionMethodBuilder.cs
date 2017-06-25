using CILantro.Engine.AST.ASTNodes.Instructions;
using CILantro.Engine.Parser.Extensions;
using CILantro.Engine.Parser.Helper;
using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionMethodBuilder : CILASTNodeBuilder<InstructionMethod>
    {
        public override InstructionMethod BuildNode(ParseTreeNode node)
        {
            string assemblyName = null;
            string className = null;
            string methodName = null;
            Type[] argumentTypes = null;

            var typeSpecificationNode = node.GetChildTypeSpecificationNode();
            var classNameNode = typeSpecificationNode.GetChildClassNameNode();

            assemblyName = ClassNameHelper.GetAssemblyName(classNameNode);
            className = ClassNameHelper.GetClassName(classNameNode);

            var methodNameNode = node.GetChildMethodNameNode();
            var methodNameNameNode = methodNameNode.GetChildNameNode();
            if(methodNameNameNode != null)
            {
                var methodNameIdNode = methodNameNameNode.GetChildIdNode();
                methodName = methodNameIdNode.ChildNodes.First().Token.ValueString;
            }

            var argumentsTypesList = new List<Type>();
            var signatureArguments0Node = node.GetChildSignatureArguments0Node();
            var signatureArguments1Node = signatureArguments0Node.GetChildSignatureArguments1Node();
            while(signatureArguments1Node != null)
            {
                var signatureArgumentNode = signatureArguments1Node.GetChildSignatureArgumentNode();
                var typeNode = signatureArgumentNode.GetChildTypeNode();
                var typeName = typeNode.ChildNodes.First().Token.ValueString;

                var typeClassNameNode = typeNode.GetChildClassNameNode();
                var typeAssemblyName = typeClassNameNode != null ? ClassNameHelper.GetAssemblyName(typeClassNameNode) : null;
                var typeClassName = typeClassNameNode != null ? ClassNameHelper.GetClassName(typeClassNameNode) : null;

                var type = TypeHelper.GetTypeByName(typeName, typeAssemblyName, typeClassName);
                argumentsTypesList.Add(type);

                signatureArguments1Node = signatureArguments1Node.GetChildSignatureArguments1Node();
            }
            argumentsTypesList.Reverse();
            argumentTypes = argumentsTypesList.ToArray();

            var instructionMethodNode = node.GetChildInstructionMethodNode();

            var callTokenNode = instructionMethodNode.GetChildCallTokenNode();
            if(callTokenNode != null)
            {
                return new CallInstruction
                {
                    AssemblyName = assemblyName,
                    ClassName = className,
                    MethodName = methodName,
                    ArgumentsTypes = argumentTypes
                };
            }

            var callvirtTokenNode = instructionMethodNode.GetChildCallvirtTokenNode();
            if(callvirtTokenNode != null)
            {
                return new CallVirtualInstruction
                {
                    AssemblyName = assemblyName,
                    ClassName = className,
                    MethodName = methodName,
                    ArgumentsTypes = argumentTypes
                };
            }

            throw new ArgumentException("Cannot recognize instruction method.");
        }
    }
}