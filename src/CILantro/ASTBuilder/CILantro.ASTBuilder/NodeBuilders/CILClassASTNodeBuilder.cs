using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILClassASTNodeBuilder : CILASTNodeBuilder<CILClass>
    {
        private readonly CILMethodASTNodeBuilder _methodBuilder;

        private readonly CILClassFieldASTNodeBuilder _fieldBuilder;

        public CILClassASTNodeBuilder()
        {
            _methodBuilder = new CILMethodASTNodeBuilder();
            _fieldBuilder = new CILClassFieldASTNodeBuilder();
        }

        public override CILClass BuildNode(ParseTreeNode node)
        {
            var methods = new List<CILMethod>();
            var constructors = new List<CILMethod>();
            var fields = new List<CILClassField>();

            var classHeadParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.classHead);
            var classNameParseTreeNode = classHeadParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.className);
            var className = ClassNameParseTreeNodeHelper.GetClassName(classNameParseTreeNode);

            var extendsClauseParseTreeNode = classHeadParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.extendsClause);
            var extendsClassNameParseTreeNode = extendsClauseParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.className);
            var extendsClassName = ClassNameParseTreeNodeHelper.GetClassName(extendsClassNameParseTreeNode);

            var classDeclsParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.classDecls);
            while(classDeclsParseTreeNode != null)
            {
                var classDeclParseTreeNode = classDeclsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.classDecl);

                var methodDeclsParseTreeNode = classDeclParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.methodDecls);
                if(methodDeclsParseTreeNode != null)
                {
                    var method = _methodBuilder.BuildNode(classDeclParseTreeNode);

                    if (method.IsConstructor) constructors.Add(method);
                    else methods.Add(method);
                }

                var fieldDeclParseTreeNode = classDeclParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.fieldDecl);
                if(fieldDeclParseTreeNode != null)
                {
                    var field = _fieldBuilder.BuildNode(fieldDeclParseTreeNode);
                    fields.Add(field);
                }

                classDeclsParseTreeNode = classDeclsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.classDecls);
            }

            fields.Reverse();

            var staticFields = new Dictionary<string, object>();
            foreach(var field in fields)
            {
                if (field.IsStatic()) staticFields.Add(field.Name, null);
            }

            var result = new CILClass
            {
                Fields = fields,
                Methods = methods,
                Constructors = constructors,
                ClassName = className,
                Extends = extendsClassName,
                StaticFields = staticFields
            };

            foreach(var resultMethod in result.Methods)
            {
                resultMethod.ParentClass = result;
            }

            foreach(var resultConstructor in result.Constructors)
            {
                resultConstructor.ParentClass = result;
            }

            return result;
        }
    }
}