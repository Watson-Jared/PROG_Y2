using System;
using System.Collections.Generic;
using System.Text;

namespace LU2_Theme1_Q1
{
    internal class TextBook:Book
    {
        private int gradeLvl;

        public void setGradeLvl(int g)
        {
            this.gradeLvl = g;
        }

        public int getGradeLvl() { 
            return this.gradeLvl; 
        }
    }
}
