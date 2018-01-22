using System;
using System.IO;
using Myriagonal.Net.Core.Logging;
using Myriagonal.Net.Sys;
using NUnit.Framework;

namespace Myriagonal.Net.Tests.Sys {
    [TestFixture]
    public class SystemConsoleLoggerTest {
        private TextWriter original;
        private TextWriter mocked;
        
        [SetUp]
        public void InitializeMockedWriter() {
            original = Console.Out;
            mocked = new StringWriter();
            Console.SetOut(mocked);
        }

        [TearDown]
        public void ResetOriginalWriter() {
            Console.SetOut(original);
        }

        [Test]
        public void ShouldWriteToSystemConsole() {
            Logger logger = new SystemConsoleLogger();
            logger.Log(LoggerLevel.Debug, "Test debug message");
            Assert.That(mocked.ToString(), Is.EqualTo("DEBUG Test debug message\n"));
        }
    }
}