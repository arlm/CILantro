using Irony.Parsing;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class LexicalsFloat64ParseTreeNodeHelper
    {
        public static double GetValue(ParseTreeNode node)
        {
            var literal = node.Token.ValueString;
            return double.Parse(literal);
        }
    }
}