using System;
using System.Collections.Generic;

namespace StrategyTeplyakov
{
    public class LogProcessor
    {
        private readonly Func<List<LogEntry>> _logImporter;
        public LogProcessor(Func<List<LogEntry>> logImporter)
        {
            _logImporter = logImporter;
        }

        public void ProcessLogs()
        {
            foreach (var logEntry in _logImporter.Invoke())
            {
                SaveLogEntry(logEntry);

            }
        }

        private void SaveLogEntry(LogEntry logEntry)
        {
            Console.WriteLine(logEntry);
        }
    }
}