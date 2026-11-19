using System;
using System.Collections.Generic;
using System.Text;

namespace MarkCaptureSystem
{
    internal class Student
    {
        private string name;
        private int test1;
        private int test2;
        private double final;

        public Student(string name, int test1, int test2)
        {
            this.name = name;
            this.test1 = test1;
            this.test2 = test2;           
        }

        public double CalculateFinal()
        {
            final = (test1 + test2) / 2.0;
            return final;
        }

        public void writeTo()
        {
            try
            {
                StreamWriter sw = new StreamWriter("Students.txt");
                sw.Write(name + "," + test1 + "," + test2 + "," + final);
                sw.Close();
            }
            catch (Exception e)
            {

            }
        }
    }
}
