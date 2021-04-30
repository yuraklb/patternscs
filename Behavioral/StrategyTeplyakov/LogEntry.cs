using System;

namespace StrategyTeplyakov
{
    public class LogEntry
    {
        public DateTime DateTime { get; set; }
        public string Severity { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"{this.DateTime.ToShortDateString()} {this.DateTime.ToShortTimeString()} {this.Severity} {this.Message}";
        }
    }
}