using System;
using System.Reflection;

namespace CILantro.Engine.Parser.Helper
{
    public static class TypeHelper
    {
        public static Type GetTypeByName(string typeName, string assemblyName, string className)
        {
            switch(typeName)
            {
                case "bool":
                    return typeof(bool);
                case "char":
                    return typeof(char);
                case "class":
                    var reflectedAssembly = Assembly.Load(assemblyName);
                    var reflectedClass = reflectedAssembly.GetType(className);
                    return reflectedClass;
                case "int32":
                    return typeof(int);
                case "object":
                    return typeof(object);
                case "string":
                    return typeof(string);
                default:
                    throw new ArgumentException("Cannot recognize type name.");
            }
        }
    }
}