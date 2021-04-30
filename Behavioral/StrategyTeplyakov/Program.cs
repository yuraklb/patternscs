using System;
using System.Collections.Generic;

namespace StrategyTeplyakov
{
    /*
     * Назначение:
     * определяет семейство алгоритмов, инкапсулирует каждый из них и делает их взаимозаменяемыми.
     * Стратегия позволяет изменять алгоритмы независи- мо от клиентов, которые ими пользуются.
     *
     * Другими словами:
     * стратегия инкапсулирует определенное поведение с возможно- стью его подмены.
     */
    
    
    /*
     * Другими словами, стратегия обеспечивает точку расширения системы в определенной плоскости:
     * класс-контекст принимает экземпляр стратегии и не знает, какой вариант стратегии он собирается использовать.
     */
    
    class Program
    {
        static void Main(string[] args)
        {
            var logProcessor = new LogProcessor(GetLogsFromFile);
            
            logProcessor.ProcessLogs();
            
            var logProcessor2 = new LogProcessor(GetLogsFromSQL);
            
            logProcessor2.ProcessLogs();
            
            
            
            Console.WriteLine("Hello World!");
        }

        private static List<LogEntry> GetLogsFromFile()
        {
            return new List<LogEntry>()
            {
                new LogEntry()
                {
                    DateTime = DateTime.Now,
                    Message = "Message from file1",
                    Severity = "FILE"
                },
                new LogEntry()
                {
                    DateTime = DateTime.Now,
                    Message = "Message from file2",
                    Severity = "FILE"
                },
            };
        }
        
        private static List<LogEntry> GetLogsFromSQL()
        {
            return new List<LogEntry>()
            {
                new LogEntry()
                {
                    DateTime = DateTime.Now,
                    Message = "Message from SQL1",
                    Severity = "SQL"
                },
                new LogEntry()
                {
                    DateTime = DateTime.Now,
                    Message = "Message from SQL2",
                    Severity = "SQL"
                },
            };
        }
    }
}