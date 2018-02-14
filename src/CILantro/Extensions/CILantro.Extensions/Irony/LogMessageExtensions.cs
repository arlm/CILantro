using Irony;

// TODO - REFAKTORING

namespace CILantro.Extensions.Irony
{
    public static class LogMessageExtensions
    {
        public static string UserFriendlyMessage(this LogMessage logMessage)
        {
            return $"Cannot parse the source code. {logMessage.Location}: {logMessage.Message}";
        }
    }
}