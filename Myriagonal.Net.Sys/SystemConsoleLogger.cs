using System;
using Myriagonal.Net.Core.Logging;

namespace Myriagonal.Net.Sys {
    public class SystemConsoleLogger : Logger {
        public void Log(LoggerLevel level, string message) {
            Console.WriteLine($"{level.ToString().ToUpperInvariant()} {message}");
        }
    }
}