using System;

namespace InputDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var programName = args[0];
                var inputDataFolderPath = args[1];

                var inputDataCreator = InputDataCreatorFactory.CreateInputDataCreator(programName);
                inputDataCreator.CreateInputData(inputDataFolderPath);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
        }
    }
}