using System;
using System.Collections.Generic;
using System.Threading;

namespace Bars_Task3
{
    class Program
    {
        private static readonly DummyRequestHandler RequestHandler =
            new DummyRequestHandler();

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите текст запроса для отправки. " +
                              "Для выхода введите /exit");
            string request;

            while ((request = Console.ReadLine()) != "/exit")
            {
                CreateRequest(request);
                Console.WriteLine("Введите текст запроса для отправки. " +
                                  "Для выхода введите /exit");
            }

            Console.WriteLine("Конец работы");
        }

        private static void CreateRequest(string message)
        {
            Console.WriteLine("Будет послано сообщение '" + message + "'");
            Console.WriteLine("Введите аргументы сообщения. " +
                              "Если аргументы не нужны - введите /end");
            var args = new List<string>();
            string argument;

            while ((argument = Console.ReadLine()) != "/end")
            {
                args.Add(argument);
                Console.WriteLine("Введите следующий аргумент сообщения. " +
                                  "Для окончания добавления аргументов введите /end");
            }

            var id = Guid.NewGuid().ToString("D");
            Console.WriteLine("Было отправлено сообщение '" + message + "'. " +
                              "Присвоен идентификатор " + id);
            ThreadPool.QueueUserWorkItem(_ => HandleRequest(id, message, args.ToArray()));
        }

        private static void HandleRequest(string id, string message, string[] args)
        {
            try
            {
                var answer = RequestHandler.HandleRequest(message, args);
                Console.WriteLine("Сообщение с идентификатором " + id +
                                  " получило ответ - " + answer);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Сообщение с идентификатором " + id +
                                  " упало с ошибкой: " + exception.Message);
            }
        }
    }
}
