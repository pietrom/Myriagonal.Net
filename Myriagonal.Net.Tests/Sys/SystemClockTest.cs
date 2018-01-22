using System;
using Myriagonal.Net.Core;
using Myriagonal.Net.Sys;
using NUnit.Framework;

namespace Myriagonal.Net.Tests.Sys {
    [TestFixture]
    public class SystemClockTest {
        [Test]
        public void ShoulsUseSystemClock() {
            Clock clock = new SystemClock();
            DateTimeOffset before = DateTimeOffset.Now;
            DateTimeOffset current = clock.Now;
            DateTimeOffset after = DateTimeOffset.Now;
        }
    }
}