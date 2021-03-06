using System;

namespace BARS_Task2
{
    class Program
    {
        private static string fileLocation = "./test.txt"; 

        public static void Main(string[] args)
        {
            var intLogger1 = new LocalFileLogger<int>(fileLocation);
            intLogger1.LogInfo("LogInfo int test passed");
            intLogger1.LogWarning("LogWarning int test passed");
            intLogger1.LogError("LogWarning int test passed", new Exception("Exception int"));

            var stringLogger = new LocalFileLogger<string>(fileLocation);
            stringLogger.LogInfo("LogInfo string test passed");
            stringLogger.LogWarning("LogWarning string test passed");
            stringLogger.LogError("LogWarning string test passed", new Exception("Exception string "));

            var variablesLogger = new LocalFileLogger<Variables>(fileLocation);
            variablesLogger.LogInfo("LogInfo variables test passed");
            variablesLogger.LogWarning("LogWarning variables test passed");
            variablesLogger.LogError("LogWarning variables test passed", new Exception("Exception variables"));
        }
    }
}
