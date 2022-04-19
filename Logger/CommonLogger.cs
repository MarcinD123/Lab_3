using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers { get; set; }

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }
        public void Log(params string[] messages)
        {
            foreach (var item in loggers)
            {
                item.Log(messages);
            }
        }
        public void Dispose()
        {
        }
    }
}
