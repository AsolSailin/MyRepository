using System;
using System.Threading;

namespace Bars_Task3
{
    public interface IRequestHandler
    {
        string HandleRequest(string message, string[] arguments);
    }
}
