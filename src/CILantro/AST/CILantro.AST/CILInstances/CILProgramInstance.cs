using CILantro.AST.CILASTNodes;
using CILantro.AST.CILCustomTypes;
using CILantro.AST.HelperClasses;
using CILantro.AST.RuntimeTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.AST.CILInstances
{
    public class CILProgramInstance
    {
        public CILProgram Program { get; private set; }

        public Dictionary<string, CILantroType> CustomTypes { get; private set; }

        public CILProgramInstance(CILProgram program)
        {
            Program = program;

            CustomTypes = RegisterCustomTypes(program);
        }

        public CILMethodInstance CreateEntryPointInstance()
        {
            return Program.GetEntryPoint().CreateInstance(null, new object[0]);
        }

        public CILantroType GetCustomType(CILClassName className)
        {
            if (CustomTypes.ContainsKey(className.UniqueName)) return CustomTypes[className.UniqueName];
            return null;
        }

        private Dictionary<string, CILantroType> RegisterCustomTypes(CILProgram program)
        {
            var result = new Dictionary<string, CILantroType>();

            var runtimeTypeFactory = new RuntimeTypeFactory(Program.Assemblies.SingleOrDefault(), program.Modules.SingleOrDefault());

            foreach(var cilClass in program.Classes)
            {
                Type runtimeType = null;
                var customType = new CILantroType(cilClass, this);

                if (RuntimeTypeHelper.GetRuntimeType(cilClass.Extends) == typeof(Enum))
                {
                    runtimeType = runtimeTypeFactory.RegisterEnumType(cilClass);
                }
                else if(RuntimeTypeHelper.GetRuntimeType(cilClass.Extends) != null)
                {
                    runtimeType = runtimeTypeFactory.RegisterType(cilClass, this, customType);
                }

                cilClass.RuntimeType = runtimeType;
                customType._runtimeType = runtimeType;

                result.Add(cilClass.ClassName.UniqueName, customType);
            }

            return result;
        }
    }
}