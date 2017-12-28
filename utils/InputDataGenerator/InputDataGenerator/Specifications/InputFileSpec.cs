using System.Collections.Generic;

namespace InputDataGenerator.Specifications
{
    public class InputFileSpec
    {
        public string FileName { get; set; }

        public IEnumerable<InputFileLine> FileLines { get; set; }
    }
}