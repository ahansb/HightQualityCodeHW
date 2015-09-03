using System;
using System.Linq;
using log4net;
using log4net.Config;


namespace TestDecompile
{
    public class TestDecompile
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(TestDecompile));
        static void Main(string[] args)
        {
            Console.WriteLine("test tetstststtstst");
            PrintName();

           BasicConfigurator.Configure();
        
        logger.Debug("Here is a debug log.");
        logger.Info("... and an Info log.");
        logger.Warn("... and a warning.");
        logger.Error("... and an error.");
        logger.Fatal("... and a fatal error.");

        }
        public static void PrintName()
        {
            Console.WriteLine("Name");
        }
    }
}
