using System;
using System.Collections.Generic;
using System.Text;

namespace LU1LO1_2_Q1
{
    internal class TempFileTracker
    {
        private string fileName;

        public TempFileTracker(string file)
        {
            fileName = file;
            Console.WriteLine($"File: {fileName} created");
        }

        public void WriteContent(string text)
        {
            Console.WriteLine($"Writing: {text}");
        }
        ~TempFileTracker()
        {
            Console.WriteLine($"Finalizer: File {fileName} cleaned up");
        }


    }
}
