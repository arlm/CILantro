using System.Collections.Generic;

namespace InputDataGenerator.Specifications
{
    public abstract class InputLineSpec
    {
        protected readonly IEnumerable<InputItemSpec> _inputItemSpecs;

        public InputLineSpec(IEnumerable<InputItemSpec> inputItemSpecs)
        {
            _inputItemSpecs = inputItemSpecs;
        }

        public abstract IEnumerable<InputFileLine> NextInputFileLines();

        public abstract void Reset();
    }
}