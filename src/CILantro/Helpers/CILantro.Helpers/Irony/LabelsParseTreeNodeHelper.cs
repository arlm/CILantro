using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System.Collections.Generic;

namespace CILantro.Helpers.Irony
{
    public static class LabelsParseTreeNodeHelper
    {
        public static List<string> GetLabels(ParseTreeNode node)
        {
            var result = new List<string>();

            var labelsNode = node;
            while(labelsNode != null)
            {
                var idParseTreeNode = labelsNode.GetFirstChildWithGrammarName(GrammarNames.id);
                var label = IdParseTreeNodeHelper.GetValue(idParseTreeNode);
                result.Add(label);

                labelsNode = labelsNode.GetFirstChildWithGrammarName(GrammarNames.labels);
            }

            return result;
        }
    }
}