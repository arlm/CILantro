using System;
using System.Collections.Generic;
using System.Linq;

namespace InputDataGenerator.Specifications
{
    public class InputLine : InputLineSpec
    {
        public InputLine(IEnumerable<InputItemSpec> inputItemSpecs)
            : base(inputItemSpecs)
        {
        }

        public override IEnumerable<InputFileLine> NextInputFileLines()
        {
            if (_inputItemSpecs.Count() > 1) throw new NotImplementedException("Input lines with more than one item are not supported yet.");

            var result = new List<InputFileLine>();

            var inputItemSpec = _inputItemSpecs.FirstOrDefault();
            if (inputItemSpec == null) return result;

            var value = inputItemSpec.NextValue();
            if (value == null) return result;

            result.Add(new InputFileLine(value));
            return result;
        }

        public override void Reset()
        {
            foreach (var inputItemSpec in _inputItemSpecs) inputItemSpec.Reset();
        }
    }
}