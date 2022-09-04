using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.common
{
    public static class Logger
    {
        public static void Log(string textToLog)
            => Console.WriteLine($"Log: {textToLog}");

    }
}
