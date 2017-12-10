using InputDataGenerator.Extensions;
using InputDataGenerator.Helpers;
using System;
using System.IO;

namespace InputDataGenerator.InputDataCreators
{
    public class UIntInputDataCreator : IInputDataCreator
    {
        private readonly Random _random;

        private readonly int _numberOfFiles;

        public UIntInputDataCreator(int numberOfFiles)
        {
            _random = new Random();

            _numberOfFiles = numberOfFiles;
        }

        public void CreateInputData(string folderPath)
        {
            for (int i = 1; i <= _numberOfFiles; i++)
            {
                var inputFileName = FileNameHelper.GenerateFileName("uint_", ".in", i, _numberOfFiles);
                var inputFilePath = Path.Combine(folderPath, inputFileName);

                var inputFileWriter = new StreamWriter(inputFilePath);
                inputFileWriter.WriteLine(_random.NextUInt());
                inputFileWriter.Close();
            }
        }
    }
}