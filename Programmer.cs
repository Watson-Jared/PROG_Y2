using System;
using System.Collections.Generic;
using System.Text;

namespace InheriteEmployee
{
    internal class Programmer : Employee
    {
        private int hours;
        private double rate;

        public Programmer()
            : base()
        {
            hours = 0;
            rate = 0.0;
        }

        public Programmer(string n, string s, int h, double r)
            : base(n, s)
        {
            hours = h;
            rate = r;
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }   

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public override double calcPay()
        {
            return base.calcPay()+(hours* rate);
        }

        public override string ToString()
        {
            return base.ToString() + " " + hours + " " + rate +" " + calcPay();
        }
    }
}
