using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
namespace LogentriesLog4NetSampleApp
{
    class Program
    {
        private static readonly ILog loggerLe = LogManager.GetLogger( typeof(Program));
        

        static void Main(string[] args)
        {
            loggerLe.Info("This is a test message");
            loggerLe.Info("This is a test message");
            loggerLe.Info("This is a test message");
            loggerLe.Info("This is a test message");
            loggerLe.Info("This is a test message");
            loggerLe.Info("This is a test message");
            loggerLe.Info("This is a test message");
            loggerLe.Info("This is a test message");
            loggerLe.Info("This is a test message");

            String x = System.Console.ReadLine();
        }
    }
}
