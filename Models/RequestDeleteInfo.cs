using System;

namespace Facebook.DataDeleteExample
{
    public class RequestDeleteInfo
    {
        public string Id { get; set; }
        public long UserId { get; set; }
        public DateTimeOffset RequestedAt { get; set; }
    }
}