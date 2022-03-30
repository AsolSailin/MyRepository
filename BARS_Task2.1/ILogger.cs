using System;

namespace BARS_Task2
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message, Exception ex);
    }
}
