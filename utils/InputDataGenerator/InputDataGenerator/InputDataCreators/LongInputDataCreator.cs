using InputDataGenerator.Extensions;
using InputDataGenerator.Helpers;
using System;
using System.IO;

namespace InputDataGenerator.InputDataCreators
{
    public class LongInputDataCreator : IInputDataCreator
    {
        private readonly Random _random;

        private readonly int _numberOfFiles;

        public LongInputDataCreator(int numberOfFiles)
        {
            _random = new Random();

            _numberOfFiles = numberOfFiles;
        }

        public void CreateInputData(string folderPath)
        {
            for(int i = 1; i <= _numberOfFiles; i++)
            {
                var inputFileName = FileNameHelper.GenerateFileName("long_", ".in", i, _numberOfFiles);
                var inputFilePath = Path.Combine(folderPath, inputFileName);

                var inputFileWriter = new StreamWriter(inputFilePath);
                inputFileWriter.WriteLine(_random.NextLong());
                inputFileWriter.Close();
            }
        }
    }
}