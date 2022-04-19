using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab_3.Logger
{
    public abstract class WriterLogger : ILogger
    {

        public void Log(params string[] message)
        {
            //Console.WriteLine("xDD");
            WriterLogger xd = new ConsoleLogger(message);
        }
        public void Dispose()
        {
        }

    }
}
