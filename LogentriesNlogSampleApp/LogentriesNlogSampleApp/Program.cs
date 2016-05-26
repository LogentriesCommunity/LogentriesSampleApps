using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace LogentriesNlogSampleApp
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Debug("Debugging message");
            logger.Info("Info message");
            logger.Warn("Warning message");
            logger.Error("Error message");
            logger.Fatal("{Error:{Test='fail' IP:'1.0.0.127' JSON: 'TRUE'}}");
            String a = System.Console.ReadLine();
        }
    }
}
