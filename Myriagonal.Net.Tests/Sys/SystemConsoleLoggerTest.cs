using System;
using System.IO;
using Myriagonal.Net.Core.Logging;
using Myriagonal.Net.Sys;
using NUnit.Framework;

namespace Myriagonal.Net.Tests.Sys {
    [TestFixture]
    public class SystemConsoleLoggerTest {
        private const string LogMessage = "Test log message";
        
        private TextWriter original;
        private TextWriter mocked;
        private Logger logger;
        
        [SetUp]
        public void InitializeMockedWriter() {
            original = Console.Out;
            mocked = new StringWriter();
            Console.SetOut(mocked);
        }

        [SetUp]
        public void InitializeLogger() {
            logger = new SystemConsoleLogger();
        }

        [TearDown]
        public void ResetOriginalWriter() {
            Console.SetOut(original);
        }

        [TestCase(LoggerLevel.Trace, LogMessage, "TRACE")]
        [TestCase(LoggerLevel.Debug, LogMessage, "DEBUG")]
        [TestCase(LoggerLevel.Info, LogMessage, "INFO")]
        [TestCase(LoggerLevel.Warn, LogMessage, "WARN")]
        [TestCase(LoggerLevel.Error, LogMessage, "ERROR")]
        public void ShouldWriteToSystemConsole(LoggerLevel level, string message, string expectedPrefix) {
            logger.Log(level, message);
            Assert.That(mocked.ToString(), Is.EqualTo($"{expectedPrefix} {message}\n"));
        }

        [Test]
        public void CanTrace() {
            logger.Trace(LogMessage);
            Assert.That(mocked.ToString(), Is.EqualTo($"TRACE {LogMessage}\n"));
        }
        [Test]
        public void CanLogDebug() {
            logger.Debug(LogMessage);
            Assert.That(mocked.ToString(), Is.EqualTo($"DEBUG {LogMessage}\n"));
        }
        [Test]
        public void CanLogInfo() {
            logger.Info(LogMessage);
            Assert.That(mocked.ToString(), Is.EqualTo($"INFO {LogMessage}\n"));
        }
        [Test]
        public void CanLogWarn() {
            logger.Warn(LogMessage);
            Assert.That(mocked.ToString(), Is.EqualTo($"WARN {LogMessage}\n"));
        }
        [Test]
        public void CanLogError() {
            logger.Error(LogMessage);
            Assert.That(mocked.ToString(), Is.EqualTo($"ERROR {LogMessage}\n"));
        }
    }
}