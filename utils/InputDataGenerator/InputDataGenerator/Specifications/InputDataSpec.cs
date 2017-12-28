using InputDataGenerator.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace InputDataGenerator.Specifications
{
    public class InputDataSpec
    {
        private const int MAX_FILE_NUMBER = 1000000;

        private readonly IEnumerable<InputLineSpec> _inputLineSpecs;

        private int _currentFileNumber;

        public InputDataSpec(IEnumerable<InputLineSpec> inputLineSpecs)
        {
            _inputLineSpecs = inputLineSpecs;

            _currentFileNumber = 1;
        }

        public InputFileSpec NextInputFile()
        {
            var nextInputFileLines = _inputLineSpecs.SelectMany(ils => ils.NextInputFileLines()).ToList();
            if (!nextInputFileLines.Any() || nextInputFileLines.Contains(null)) return null;

            var result = new InputFileSpec
            {
                FileName = FileNameHelper.GenerateFileName("generic_", ".in", _currentFileNumber, MAX_FILE_NUMBER),
                FileLines = nextInputFileLines
            };

            _currentFileNumber++;

            return result;
        }
    }
}