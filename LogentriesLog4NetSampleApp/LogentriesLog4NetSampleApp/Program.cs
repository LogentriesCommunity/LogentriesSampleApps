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
        private static readonly ILog logger = LogManager.GetLogger( typeof(Program));
        static void Main(string[] args)
        {
            logger.Debug("Debugging message");
            logger.Info("Info message");
            logger.Warn("Warning message");
            logger.Error("Error message");
            logger.Fatal("Fatal message");

            String x = System.Console.ReadLine();
        }
    }
}
