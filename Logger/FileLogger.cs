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
        private bool disposed;
        protected FileStream stream;
        //TextWriter writer;
        public FileLogger(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Append);
            this.stream = stream;
            writer = new StreamWriter(stream, Encoding.UTF8);
        }
        string time = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");

        public override void Log(params string[] messages)
        {
            //Console.WriteLine("reeeeeeeeeeee");
            
                
                
                if (messages.Length == 1)
                {
                    
                    writer.WriteLine(time + " " + messages[0]);
                }
                else
                {
                    writer.Write(time + " ");
                    foreach (var item in messages)
                    {
                        writer.Write(item + " ");
                    }
                
                //writer.Write("xD");
                this.writer.Flush();
                //writer.Close(); stream.Close();
                //writer.Dispose(); stream.Dispose();
            }
        }
        public void Dispose()
        {
            
        }
    }
}
