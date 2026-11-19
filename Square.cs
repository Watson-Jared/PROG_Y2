using System;
using System.Collections.Generic;
using System.Text;

namespace LU2_Theme1_Q2
{
    internal class Square
    {
        private int height;
        private int width;
        private int surfaceArea;

        public Square()
        {
            height = 0;
            width = 0;
            
        }

        public Square(int h, int w)
        {
            this.height = h;
            this.width = w;
            
        }

        public int computeSurfaceArea()
        {
            surfaceArea = width * width;
            return surfaceArea;
        }
    }
}
