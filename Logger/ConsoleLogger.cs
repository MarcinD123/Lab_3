using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    class ConsoleLogger : WriterLogger
    {

        public ConsoleLogger(params string[] messages)
        {
            foreach (var item in messages)
            {
                Console.WriteLine(item);
                //Console.WriteLine("data");
            }
        }
        
    }
}
