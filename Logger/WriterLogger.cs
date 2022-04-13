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

        protected FileStream stream;
        protected TextWriter writer;

        
        public   void Log(params string[] messages)  //virtual?
        {
            Console.WriteLine("xddd");
            //Uzupełnić to miejsce o logikę zapisu opartą o TextWriter...
            using (FileStream stream = new FileStream("file.txt", FileMode.Append))
            using (TextWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                string time = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
                writer.Write("xD");
                //Console.WriteLine("xD");
                Console.WriteLine(messages.Length);
                //Console.WriteLine(messages[0]);
                if (messages.Length == 1)
                {
                    Console.WriteLine("reee");
                    writer.Write(messages.ToString());
                    writer.Flush();
                }
                else
                {


                    foreach (var item in messages)
                    {
                        Console.WriteLine("reee");
                        writer.Write(item.ToString());
                    }
                    //writer.Write(messages.ToString());
                    writer.Flush();
                }
            }
        }

        public abstract void Dispose();

    }
}
