using CILantro.AST.CILASTNodes;
using CILantro.AST.CILCustomTypes;
using CILantro.AST.CILInstances;
using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

// TODO - REFAKTORING

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

        public Type RegisterType(CILClass cilClass, CILProgramInstance programInstance, CILantroType cilantroType)
        {
            var parentTypeAssembly = Assembly.Load(cilClass.Extends.AssemblyName);
            var parentType = parentTypeAssembly.GetType(cilClass.Extends.ClassName);

            var typeBuilder = _moduleBuilder.DefineType(cilClass.ClassName.ClassName, TypeAttributes.Class, parentType);

            foreach(var method in parentType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if (method.IsAbstract)
                {
                    //typeBuilder.DefineMethodOverride(method, method);
                    var methodBuilder = typeBuilder.DefineMethod(method.Name, (method.Attributes & (~MethodAttributes.Abstract)), method.ReturnType, method.GetParameters().Select(p => p.ParameterType).ToArray());
                    var msil = methodBuilder.GetILGenerator();
                    msil.ThrowException(typeof(NotImplementedException));
                    typeBuilder.DefineMethodOverride(methodBuilder, method);

                    //var cilMethods = cilClass.Methods.Select(m => new CILantroMethodInfo(m, programInstance, typeBuilder)).ToList();
                    //var cilMethod = cilMethods.SingleOrDefault(m => m.Name == method.Name && CILantroType.CompareArgumentTypes(m.GetParameters().Select(p => p.ParameterType).ToArray(), method.GetParameters().Select(p => p.ParameterType).ToArray()));
                    //typeBuilder.DefineMethodOverride(cilMethod, method);
                }
            }

            var type = typeBuilder.CreateType();
            return type;
        }
    }
}