using System;
using System.Collections.Generic;
using System.Text;

namespace LU2_Theme1_Q1
{
    internal class Book
    {
        private String title;
        private int numOfPages;

        public void setTitle(String t)
        {
            title = t;
        }

        public void setNumOfPages(int n)
        {
            numOfPages = n;
        }

        public String getTitle()
        {
            return title;
        }

        public int getNumOfPages()
        {
            return numOfPages;
        }
    }
   
}
