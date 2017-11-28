using System.IO;

namespace InputDataGenerator.InputDataCreators
{
    public class EmptyInputDataCreator : IInputDataCreator
    {
        public void CreateInputData(string folderPath)
        {
            var emptyInputFilePath = Path.Combine(folderPath, "empty.in");
            var emptyInputFileWriter = new StreamWriter(emptyInputFilePath);

            emptyInputFileWriter.Close();
        }
    }
}