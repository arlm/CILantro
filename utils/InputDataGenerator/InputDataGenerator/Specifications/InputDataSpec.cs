using System.Collections.Generic;

namespace InputDataGenerator.Specifications
{
    public class InputDataSpec
    {
        private readonly int _maxNumberOfFiles;
        private readonly IEnumerable<InputLineSpec> _inputLineSpecs;

        public InputDataSpec(int maxNumberOfFiles, IEnumerable<InputLineSpec> inputLineSpecs)
        {
            _maxNumberOfFiles = maxNumberOfFiles;
            _inputLineSpecs = inputLineSpecs;
        }

        public List<InputFileSpec> GenerateInputFiles()
        {
            return new List<InputFileSpec>();
        }
    }
}