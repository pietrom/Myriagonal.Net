using System;
using Myriagonal.Net.Core.Logging;

namespace Myriagonal.Net.Sys {
    public class SystemConsoleLogger : Logger {
        public void Log(LoggerLevel level, string message) {
            Console.WriteLine($"{level.ToString().ToUpperInvariant()} {message}");
        }

        public void Trace(string message) {
            Log(LoggerLevel.Trace, message);
        }

        public void Debug(string message) {
            Log(LoggerLevel.Debug, message);
        }

        public void Info(string message) {
            Log(LoggerLevel.Info, message);
        }

        public void Warn(string message) {
            Log(LoggerLevel.Warn, message);
        }

        public void Error(string message) {
            Log(LoggerLevel.Error, message);
        }
    }
}