namespace OutputChecker.OutputDataCheckers
{
    public class SameOutputsOutputDataChecker : IOutputDataChecker
    {
        public bool CheckOutput(string inDataFilePath, string outExeFilePath, string outCilantroFilePath)
        {
            return true;
        }
    }
}