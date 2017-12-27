﻿using InputDataGenerator.Extensions;
using InputDataGenerator.Helpers;
using System;
using System.IO;

namespace InputDataGenerator.InputDataCreators
{
    public class ULongInputDataCreator : IInputDataCreator
    {
        private readonly Random _random;

        private readonly int _numberOfFiles;

        public ULongInputDataCreator(int numberOfFiles)
        {
            _random = new Random();

            _numberOfFiles = numberOfFiles;
        }

        public void CreateInputData(string folderPath)
        {
            for (int i = 1; i <= _numberOfFiles; i++)
            {
                var inputFileName = FileNameHelper.GenerateFileName("uLong_", ".in", i, _numberOfFiles);
                var inputFilePath = Path.Combine(folderPath, inputFileName);

                var inputFileWriter = new StreamWriter(inputFilePath);
                inputFileWriter.WriteLine(_random.NextULong());
                inputFileWriter.Close();
            }
        }
    }
}
