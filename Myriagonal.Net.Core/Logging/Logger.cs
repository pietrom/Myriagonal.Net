namespace Myriagonal.Net.Core.Logging {
    public interface Logger {
        void Log(LoggerLevel debug, string message);

        void Trace(string message);
        void Debug(string message);
        void Info(string message);
        void Warn(string message);
        void Error(string message);
    }
}