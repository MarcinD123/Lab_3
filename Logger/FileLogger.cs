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
            FileStream stream = new FileStream(path, FileMode.Append);
            base.writer = new StreamWriter(stream, Encoding.UTF8);
        }
        public override void Dispose()
        {
            this.stream.Dispose();
        }
    }
}
