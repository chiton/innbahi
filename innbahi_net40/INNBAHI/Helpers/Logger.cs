using Serilog;
using System;

namespace INNBAHI.Helpers
{
    public class Logger
    {
        static ILogger log;

        public static ILogger Instance
        {
            get
            {
                if (log == null)
                {
                    log = new LoggerConfiguration().WriteTo.RollingFile(
                        AppDomain.CurrentDomain.BaseDirectory+ @"innbahi.log").CreateLogger();
                }

                return log; 
            }
        }
    }
}