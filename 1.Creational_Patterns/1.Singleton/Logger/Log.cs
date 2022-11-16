using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Log : ILog
    {
        private Log()
        {

        }
        private static readonly Lazy<Log> _log = new Lazy<Log>(() => new Log());

        public static Log GetInstance 
        { 
            get 
            {
                return _log.Value; 
            } 
        }

        public void LogException(string message)
        {
            string fileName = $"Exception_{DateTime.UtcNow.ToFileTimeUtc()}.log";
            string logFilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\{fileName}";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("*****************");
            stringBuilder.AppendLine(DateTime.UtcNow.ToString());
            stringBuilder.AppendLine(message);

            using(StreamWriter sw = new StreamWriter(logFilePath,true))
            {
                sw.WriteLine(stringBuilder.ToString());
                sw.Flush();
            }

           
        }
    }
}
