using System;

namespace ResourceServer.Models
{
    public class Message
    {
        public string Text { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
