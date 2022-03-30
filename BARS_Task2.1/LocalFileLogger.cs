using System;
using System.IO;

namespace BARS_Task2
{
    public class LocalFileLogger<T> : ILogger
    {
        private string fileLocation;

        public LocalFileLogger(string location)
        {
            this.fileLocation = location;
        }

        public void LogInfo(string message)
        {
            File.AppendAllText(fileLocation, $"[Info]: [{typeof(T).Name}]:{message}" + '\n');
        }

        public void LogWarning(string message)
        {
            File.AppendAllText(fileLocation, $"[Warning]: [{typeof(T).Name}]: {message}" + '\n');
        }

        public void LogError(string message, Exception ex)
        {
            File.AppendAllText(fileLocation, $"[Error]: [{typeof(T).Name}]: {message}.{ex.Message}" + '\n');
        }
    }
}
