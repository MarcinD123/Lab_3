using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    class ConsoleLogger : WriterLogger
    {

        public ConsoleLogger()
        {


        }
        string time = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
        public override void Log(params string[] messages)
        {
            if (messages.Length == 1)
            {

                Console.WriteLine(time + " " + messages[0]);
            }
            else
            {
                Console.Write(time + " ");
                foreach (var item in messages)
                {
                    Console.Write(item + " ");
                }


            }
        }
    }
}

