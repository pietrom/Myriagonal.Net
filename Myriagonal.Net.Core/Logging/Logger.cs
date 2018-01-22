namespace Myriagonal.Net.Core.Logging {
    public interface Logger {
        void Log(LoggerLevel debug, string message);
    }
}