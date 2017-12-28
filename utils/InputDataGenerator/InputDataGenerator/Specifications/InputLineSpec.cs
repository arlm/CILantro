using System.Collections.Generic;

namespace InputDataGenerator.Specifications
{
    public abstract class InputLineSpec
    {
        private readonly IEnumerable<InputItemSpec> _inputItemSpecs;

        public InputLineSpec(IEnumerable<InputItemSpec> inputItemSpecs)
        {
            _inputItemSpecs = inputItemSpecs;
        }
    }
}