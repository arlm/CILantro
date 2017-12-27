using InputDataGenerator.Extensions;
using InputDataGenerator.Helpers;
using System;
using System.Collections.Generic;
using System.IO;

namespace InputDataGenerator.InputDataCreators
{
    public class RandomInputDataCreator : IInputDataCreator
    {
        private readonly Random _random;

        private readonly int _numberOfFiles;
        private readonly List<List<Type>> _types;

        public RandomInputDataCreator(int numberOfFiles, List<List<Type>> types)
        {
            _random = new Random();

            _numberOfFiles = numberOfFiles;
            _types = types;
        }

        public void CreateInputData(string folderPath)
        {
            for (int i = 1; i <= _numberOfFiles; i++)
            {
                var inputFileName = FileNameHelper.GenerateFileName("random_", ".in", i, _numberOfFiles);
                var inputFilePath = Path.Combine(folderPath, inputFileName);

                var inputFileWriter = new StreamWriter(inputFilePath);
                foreach(var line in _types)
                {
                    foreach (var type in line)
                    {
                        var randomValue = _random.NextOfType(type);
                        inputFileWriter.Write(randomValue);
                    }

                    inputFileWriter.WriteLine();
                }
                inputFileWriter.Close();
            }
        }
    }
}