using System;
using Myriagonal.Net.Core;
using Myriagonal.Net.Dummy;
using NUnit.Framework;

namespace Myriagonal.Net.Tests.Dummy {
    [TestFixture]
    public class FixedClockTest {
        [Test]
        public void ShouldReturnProvidedDateTimeOffset() {
            DateTimeOffset dto = new DateTimeOffset(1978, 1, 1, 2, 3, 4, TimeSpan.FromHours(2));
            Clock clock = new FixedClock(dto);
            Assert.That(clock.Now, Is.EqualTo(dto));
        }
    }
}