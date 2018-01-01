using InputDataGenerator.Helpers;
using System;
using System.IO;

namespace InputDataGenerator.InputDataCreators
{
    public class RandomInputDataCreator : IInputDataCreator
    {
        private readonly Random _random;

        private readonly Action<StreamWriter, Random> _createAction;
        private readonly int _numberOfRandomInputs;

        public RandomInputDataCreator(Action<StreamWriter, Random> createAction)
        {
            _random = new Random();

            _createAction = createAction;
            _numberOfRandomInputs = Configuration.Settings.NUMBER_OF_RANDOM_INPUTS;
        }

        public void CreateInputData(string folderPath)
        {
            for(int i = 1; i <= _numberOfRandomInputs; i++)
            {
                var inputFileName = FileNameHelper.GenerateFileName("random_", ".in", i, _numberOfRandomInputs);
                var inputFilePath = Path.Combine(folderPath, inputFileName);

                using (var inputFileWriter = new StreamWriter(inputFilePath))
                {
                    _createAction.Invoke(inputFileWriter, _random);
                }
            }
        }
    }
}