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

        public virtual void Log(params string[] messages)
        {

            // Uzupełnić to miejsce o logikę zapisu opartą o TextWriter ...
            using (FileStream stream = new FileStream("file.txt", FileMode.Append))
            using (TextWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                writer.Write(messages);
                writer.Flush();
            }
        }

        public abstract void Dispose();

    }
}
