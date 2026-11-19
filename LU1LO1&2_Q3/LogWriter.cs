using System;
using System.Collections.Generic;
using System.Text;

namespace LU1LO1_2_Q3
{
    public class LogWriter: IDisposable
    {
        private StreamWriter swr;
        private bool disposed = false;

        public void writeLog(string msg) 
        { 

        }

        public LogWriter(string s)
        {
            swr = new StreamWriter();
        }

    }
}
