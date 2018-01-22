using System;
using Myriagonal.Net.Core;

namespace Myriagonal.Net.Dummy {
    public class FixedClock : Clock {
        public FixedClock(DateTimeOffset value) {
            Now = value;
            Now = value;
        }

        public DateTimeOffset Now { get; } 
    }
}