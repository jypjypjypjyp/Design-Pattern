using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = AbstractLogger.Logger;
            logger.LogMessage(AbstractLogger.INFO,
                "This is an information.");

            logger.LogMessage(AbstractLogger.DEBUG,
               "This is an debug level information.");

            logger.LogMessage(AbstractLogger.ERROR,
               "This is an error information.");

        }
    }
}
