using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers;
        //ctor
        public CommonLogger(ILogger[] loggers)
        {
            
        }

        public void Log(params string[] messages)
        {

        }

        public void Dispose()
        {

        }

    }
}
