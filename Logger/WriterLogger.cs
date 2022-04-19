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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
        public virtual void Log(params string[] messages) 
        {


            
                
            

        }



       


    }
}
