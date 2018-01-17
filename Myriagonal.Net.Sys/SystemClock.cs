using System;
using Myriagonal.Net.Core;

namespace Myriagonal.Net.Sys {
    public class SystemClock : Clock {
        public DateTimeOffset Now => DateTimeOffset.UtcNow;
    }
}