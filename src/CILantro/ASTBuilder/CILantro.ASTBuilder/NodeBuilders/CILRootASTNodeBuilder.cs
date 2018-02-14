using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System.Collections.Generic;
using System.Linq;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILRootASTNodeBuilder : CILASTNodeBuilder<CILProgram>
    {
        private readonly CILClassASTNodeBuilder _classBuilder;

        private readonly CILAssemblyASTNodeBuilder _assemblyBuilder;

        private readonly CILExternalAssemblyASTNodeBuilder _externalAssemblyBuilder;

        private readonly CILModuleASTNodeBuilder _moduleBuilder;

        public CILRootASTNodeBuilder()
        {
            _classBuilder = new CILClassASTNodeBuilder();
            _assemblyBuilder = new CILAssemblyASTNodeBuilder();
            _externalAssemblyBuilder = new CILExternalAssemblyASTNodeBuilder();
            _moduleBuilder = new CILModuleASTNodeBuilder();
        }

        public override CILProgram BuildNode(ParseTreeNode node)
        {
            var classes = new List<CILClass>();
            var assemblies = new List<CILAssembly>();
            var externalAssemblies = new List<CILExternalAssembly>();
            var modules = new List<CILModule>();

            var declsParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.decls);
            while(declsParseTreeNode != null)
            {
                var declParseTreeNode = declsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.decl);

                var classDeclsParseTreeNode = declParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.classDecls);
                if(classDeclsParseTreeNode != null)
                {
                    var cilClass = _classBuilder.BuildNode(declParseTreeNode);
                    classes.Add(cilClass);
                }

                var assemblyDeclsParseTreeNode = declParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.assemblyDecls);
                if(assemblyDeclsParseTreeNode != null)
                {
                    var cilAssembly = _assemblyBuilder.BuildNode(declParseTreeNode);
                    assemblies.Add(cilAssembly);
                }

                var assemblyRefDeclsParseTreeNode = declParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.assemblyRefDecls);
                if(assemblyRefDeclsParseTreeNode != null)
                {
                    var cilExternalAssembly = _externalAssemblyBuilder.BuildNode(declParseTreeNode);
                    externalAssemblies.Add(cilExternalAssembly);
                }

                var moduleHeadParseTreeNode = declParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.moduleHead);
                if(moduleHeadParseTreeNode != null)
                {
                    var cilModule = _moduleBuilder.BuildNode(moduleHeadParseTreeNode);
                    modules.Add(cilModule);
                }

                declsParseTreeNode = declsParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.decls);
            }

            foreach (var cilClass in classes)
            {
                cilClass.ExtendsClass = classes.FirstOrDefault(c => c.ClassName.UniqueName == cilClass.Extends.UniqueName);
            }

            var result = new CILProgram
            {
                Classes = classes,
                Assemblies = assemblies,
                ExternalAssemblies = externalAssemblies,
                Modules = modules
            };

            return result;
        }
    }
}