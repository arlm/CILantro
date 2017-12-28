using InputDataGenerator.Specifications;
using System.IO;

namespace InputDataGenerator.InputDataCreators
{
    public class GenericInputDataCreator : IInputDataCreator
    {
        private readonly InputDataSpec _inputDataSpec;

        public GenericInputDataCreator(InputDataSpec inputDataSpec)
        {
            _inputDataSpec = inputDataSpec;
        }

        public void CreateInputData(string folderPath)
        {
            var inputFiles = _inputDataSpec.GenerateInputFiles();

            foreach(var inputFile in inputFiles)
            {
                var inputFilePath = Path.Combine(folderPath, inputFile.FileName);

                var inputFileWriter = new StreamWriter(inputFilePath);

                inputFileWriter.Close();
            }
        }
    }
}