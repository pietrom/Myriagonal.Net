using System;
using Myriagonal.Net.Core;

namespace Myriagonal.Net.Fake {
    public class FixedClock : Clock {
        public FixedClock(DateTimeOffset value) {
            Now = value;
        }

        public DateTimeOffset Now { get; } 
    }
}