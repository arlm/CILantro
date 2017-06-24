using System;

namespace CILantro.Engine.Parser.Helper
{
    public static class TypeHelper
    {
        public static Type GetTypeByName(string typeName)
        {
            switch(typeName)
            {
                case "bool":
                    return typeof(bool);
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