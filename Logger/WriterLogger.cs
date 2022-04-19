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
        protected TextWriter writer;
        
        



        public virtual void Log(params string[] messages) //abstract?
        {
            FileStream stream = new FileStream("file.txt", FileMode.Append);

            writer = new StreamWriter(stream, Encoding.UTF8);
             writer.Write("xD");
            // Uzupełnić to miejsce o logikę zapisu opartą o TextWriter ...
            writer.Close(); stream.Close();
            writer.Dispose(); stream.Dispose();

            //
            new ConsoleLogger(messages);
            
            
        }


        //public void Log(params string[] message)
        //{
        //    //Console.WriteLine("xDD");
        //     new ConsoleLogger(message);
        //}
        public void Dispose()
        {
            
        }

    }
}
