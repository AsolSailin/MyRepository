using System;
using System.IO;

namespace BARS_Task2
{
    // потом когда класс этот интерфейс наследует он ОБЯЗАН реализовать все методы которые были в интерфейсе
    // То теперь вон красным черкает, читаем. он не реализует этот метод а значит не выполняет
    // условия "контракта" (интерфейса) по правилам он обязан реализовать все методы
    // всё, все методы реализованы и он больше не ругается
    // понятно
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
