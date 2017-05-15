using CILantro.Engine.AST.ASTNodes;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System.Collections.Generic;

namespace CILantro.Engine.Parser.CILASTConstruction
{
    public class ClassBuilder : CILASTNodeBuilder<CILClass>
    {
        private MethodBuilder _methodBuilder;

        public ClassBuilder()
        {
            _methodBuilder = new MethodBuilder();
        }

        public override CILClass BuildNode(ParseTreeNode node)
        {
            var methods = new List<CILMethod>();

            var classDeclarationsNode = node.GetChildClassDeclarationsNode();
            var classDeclarationNode = classDeclarationsNode.GetChildClassDeclarationNode();
            while(classDeclarationNode != null)
            {
                var method = _methodBuilder.BuildNode(classDeclarationNode);
                methods.Add(method);

                classDeclarationsNode = classDeclarationsNode.GetChildClassDeclarationsNode();
                classDeclarationNode = classDeclarationsNode.GetChildClassDeclarationNode();
            }

            return new CILClass
            {
                Methods = methods
            };
        }
    }
}
