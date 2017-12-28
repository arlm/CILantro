using System.Collections.Generic;

namespace InputDataGenerator.Specifications
{
    public class InputLine : InputLineSpec
    {
        public InputLine(IEnumerable<InputItemSpec> inputItemSpecs)
            : base(inputItemSpecs)
        {

        }
    }
}