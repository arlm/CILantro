using InputDataGenerator.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InputDataGenerator.InputDataCreators
{
    public class EnumerableInputDataCreator : IInputDataCreator
    {
        private readonly IEnumerable<Action<StreamWriter>> _createActions;

        public EnumerableInputDataCreator(IEnumerable<Action<StreamWriter>> createActions)
        {
            _createActions = createActions;
        }

        public void CreateInputData(string folderPath)
        {
            var inputFilesCount = _createActions.Count();
            var inputFileNumber = 0;

            foreach(var createAction in _createActions)
            {
                inputFileNumber++;
                var inputFileName = FileNameHelper.GenerateFileName("enumerable_", ".in", inputFileNumber, inputFilesCount);
                var inputFilePath = Path.Combine(folderPath, inputFileName);

                using (var inputFileWriter = new StreamWriter(inputFilePath))
                {
                    createAction.Invoke(inputFileWriter);
                }
            }
        }
    }
}
