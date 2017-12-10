using System;

namespace InputDataGenerator.Helpers
{
    public static class FileNameHelper
    {
        public static string GenerateFileName(string prefix, string suffix, int fileNumber, int maxNumber)
        {
            var digitsNumber = Math.Floor(Math.Log10(maxNumber) + 1);
            var fileNumberString = fileNumber.ToString($"D{digitsNumber}");
            var result = $"{prefix}{fileNumberString}{suffix}";
            return result;
        }
    }
}