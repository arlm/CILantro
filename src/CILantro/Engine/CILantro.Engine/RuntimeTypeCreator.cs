using CILantro.AST.CILASTNodes;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace CILantro.Engine
{
    internal class RuntimeTypeCreator
    {
        public AssemblyBuilder CreateAssemblyBuilder(CILAssembly cilAssembly)
        {
            var assemblyName = new AssemblyName(cilAssembly.AssemblyName);
            var assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            return assemblyBuilder;
        }

        public ModuleBuilder CreateModuleBuilder(AssemblyBuilder assemblyBuilder, CILModule cilModule)
        {
            var moduleBuilder = assemblyBuilder.DefineDynamicModule(cilModule.ModuleName);
            return moduleBuilder;
        }

        public Type CreateType(ModuleBuilder moduleBuilder, CILClass cilClass)
        {
            var parentTypeAssembly = Assembly.Load(cilClass.Extends.AssemblyName);
            var parentType = parentTypeAssembly.GetType(cilClass.Extends.ClassName);

            if (parentType == typeof(Enum)) return CreateEnumType(moduleBuilder, cilClass);
            return CreateClassType(moduleBuilder, cilClass, parentType);
        }

        public Type CreateEnumType(ModuleBuilder moduleBuilder, CILClass cilClass)
        {
            var enumBuilder = moduleBuilder.DefineEnum(cilClass.ClassName.ClassName, TypeAttributes.Public, typeof(int));

            foreach (var cilField in cilClass.Fields)
            {
                if (cilField.Name != "value__")
                {
                    var fieldInitValue = Convert.ToInt32(cilField.InitValue);
                    enumBuilder.DefineLiteral(cilField.Name, fieldInitValue);
                }
            }

            var newType = enumBuilder.CreateType();
            return newType;
        }

        public Type CreateClassType(ModuleBuilder moduleBuilder, CILClass cilClass, Type parentType)
        {
            var typeBuilder = moduleBuilder.DefineType(cilClass.ClassName.ClassName, TypeAttributes.Class, parentType);

            foreach (var cilField in cilClass.Fields)
            {
                Type fieldType = null;
                if (cilField.Type.ClassName != null && cilField.Type.ClassName.ClassName == cilClass.ClassName.ClassName)
                {
                    fieldType = typeBuilder.AsType();
                }
                else if (cilField.Type.SimpleType != null)
                {
                    fieldType = cilField.Type.SimpleType;
                }

                var fieldAttributes = cilField.IsPublic() ? FieldAttributes.Public : FieldAttributes.Private;
                if (cilField.IsLiteral()) fieldAttributes |= FieldAttributes.Literal;
                if (cilField.IsStatic()) fieldAttributes |= FieldAttributes.Static;

                var fieldBuilder = typeBuilder.DefineField(cilField.Name, fieldType, fieldAttributes);
            }

            var newType = typeBuilder.CreateType();
            return newType;
        }
    }
}