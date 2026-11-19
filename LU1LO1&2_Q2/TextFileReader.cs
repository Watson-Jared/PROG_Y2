using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace LU1LO1_2_Q2
{
    public class TextFileReader : IDisposable
    {
        private StreamReader sr;
        private bool disposed = false;


        public TextFileReader(string filePath)
        {
            sr = new StreamReader(filePath);
        }

        public void readAllText()
        {
            Console.WriteLine("===Read All===\n");
            Console.WriteLine(sr.ReadToEnd());
        }

        public void readLine()
        {

            Console.WriteLine("===Read Line===\n");
            sr.BaseStream.Position = 0;
            sr.DiscardBufferedData();

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

        }

        public void Dispose()
        {
            if (!disposed)
            {
                if (sr != null) sr.Dispose();
            }
            Console.WriteLine("\nResource disposed");
        }
    }
}
