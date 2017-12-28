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
            var inputFile = _inputDataSpec.NextInputFile();
            while(inputFile != null)
            {
                var inputFilePath = Path.Combine(folderPath, inputFile.FileName);

                var inputFileWriter = new StreamWriter(inputFilePath);
                foreach(var fileLine in inputFile.FileLines)
                {
                    foreach(var item in fileLine.Items)
                    {
                        inputFileWriter.Write(item);
                    }

                    inputFileWriter.WriteLine();
                }
                inputFileWriter.Close();

                inputFile = _inputDataSpec.NextInputFile();
            }
        }
    }
}