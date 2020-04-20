using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog
{
    public sealed class Log
    {
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private Log() { }

        public static void Trace(string strMsg)
        {
            _logger.Trace(strMsg);
        }
         
        public static void Debug(string strMsg)
        {
            _logger.Debug(strMsg);
        }

        public static void Info(string strMsg)
        {
            _logger.Info(strMsg);
        }

        public static void Warn(string strMsg)
        {
            _logger.Warn(strMsg);
        }

        public static void Warn(Exception e)
        {
            _logger.Warn(e);
        }

        public static void Warn(Exception e,string strMsg)
        {
            _logger.Warn(e,strMsg);
        }
         
        public static void Error(string strMsg)
        {
            _logger.Error(strMsg);
        }

        public static void Error(Exception e, string strMsg)
        {
            _logger.Error(strMsg);
        }

        public static void Error(Exception e)
        {
            _logger.Error(e);
        }

        public static void Fatal(string strMsg)
        {
            _logger.Fatal(strMsg);
        }

    }
}
