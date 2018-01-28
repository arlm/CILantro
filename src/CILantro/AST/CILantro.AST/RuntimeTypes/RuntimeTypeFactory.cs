using CILantro.AST.CILASTNodes;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace CILantro.AST.RuntimeTypes
{
    public class RuntimeTypeFactory
    {
        private readonly AssemblyBuilder _assemblyBuilder;

        private readonly ModuleBuilder _moduleBuilder;

        public RuntimeTypeFactory(CILAssembly cilAssembly, CILModule cilModule)
        {
            var assemblyName = new AssemblyName(cilAssembly.AssemblyName);
            var assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            _assemblyBuilder = assemblyBuilder;

            var moduleBuilder = _assemblyBuilder.DefineDynamicModule(cilModule.ModuleName);
            _moduleBuilder = moduleBuilder;
        }

        public Type RegisterEnumType(CILClass enumClass)
        {
            var enumBuilder = _moduleBuilder.DefineEnum(enumClass.ClassName.ClassName, TypeAttributes.Class, typeof(int));

            foreach(var cilField in enumClass.Fields)
            {
                if(cilField.Name != "value__")
                {
                    var fieldInitValue = Convert.ToInt32(cilField.InitValue);
                    enumBuilder.DefineLiteral(cilField.Name, fieldInitValue);
                }
            }

            var enumType = enumBuilder.CreateType();
            return enumType;
        }
    }
}