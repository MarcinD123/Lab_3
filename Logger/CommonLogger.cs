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
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
        public void Log(params string[] messages)
        {
            string time = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");

            if (messages.Length == 1)
            {
                Console.WriteLine($"{time} {messages[0]}");
            }
            else
            {

                Console.Write(time + " ");
                foreach (var item in messages)
                {
                    Console.Write($"{item.ToString()} ");
                }
            }
        }


        public void Dispose()
        {

        }

    }
}
