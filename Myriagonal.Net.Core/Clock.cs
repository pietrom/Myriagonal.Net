using System;


namespace Myriagonal.Net.Core {
    public interface Clock {
        DateTimeOffset Now { get; }
    }
}