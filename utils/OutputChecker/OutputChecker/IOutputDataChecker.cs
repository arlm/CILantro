namespace OutputChecker
{
    public interface IOutputDataChecker
    {
        bool CheckOutput(string inDataFilePath, string outExeFilePath, string outCilantroFilePath);
    }
}