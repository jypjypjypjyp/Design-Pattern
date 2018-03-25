using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int level;
        protected AbstractLogger next;

        public AbstractLogger Next
        {
            set
            {
                next = value;
            }
        }

        public void LogMessage(int level, String message)
        {
            if (this.level <= level)
            {
                Write(message);
            }
            if (next != null)
            {
                next.LogMessage(level, message);
            }
        }

        public static AbstractLogger Logger
        {
            get
            {
                AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
                AbstractLogger debugLogger = new DebugLogger(AbstractLogger.DEBUG);
                AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);
                errorLogger.next = debugLogger;
                debugLogger.next = consoleLogger;
                return errorLogger;
            }
        }

        abstract protected void Write(String message);
    }
}
