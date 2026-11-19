using System;
using System.Collections.Generic;
using System.Text;

namespace InheriteEmployee
{
    internal class Employee
    {

        private string name;
        private string surname;
        public Employee()
        {
            name = string.Empty;
            surname = string.Empty;
        }

        public Employee(string n, string s)
        {
            name = n;
            surname = s;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public override string ToString()
        {
            return name + " " + surname;
        }

        public virtual double calcPay()
        {
            return 500.0;
        }
    }
}
