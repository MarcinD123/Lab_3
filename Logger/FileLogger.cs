using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    class FileLogger :WriterLogger
    {
        bool disposed;

        private FileStream stream;
        public FileLogger(string path)
        {

            

        }
        public static void   Log(string[] message)
        {
            
            using (FileStream stream = new FileStream("file.txt", FileMode.Append))
            using (TextWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                Console.WriteLine("xDa");
                Console.WriteLine(message+"xD");
                writer.Write("s");
                writer.Write(message);
                writer.Flush();
                Console.WriteLine("s");
            }

        }
        //public void Log(string message)
        //{
        //    stream.Write(message);
        //}
        //public void Log(params string[] messages)
        //{
        //    string time = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");

        //    if (messages.Length == 1)
        //    {
        //        Console.WriteLine($"{time} {messages[0]}");
        //    }
        //    else
        //    {

        //        Console.Write(time + " ");
        //        foreach (var item in messages)
        //        {
        //            Console.Write($"{item.ToString()} ");
        //        }
        //    }
        //}
        public override void Dispose()
        {
            this.stream.Dispose();
        }
    }
}
