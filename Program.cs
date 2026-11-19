namespace Employee
{
    internal class Employee
    {
        String name;
        String surname;
        String departName;
        double sales;
        public Employee() {
            name = null;
            surname = null;
            departName = null;
            sales = 0.0;
        }

        public void setName(String n)
        {
            char charAt = n[0];
            if (char.IsUpper(charAt))
            {
                name = n;
            }
            else {
                Console.WriteLine("Name does not contain uppercase first letter.");
            }
        }

        static bool IsAllUpper(string str)
        {
            foreach (char c in str)
                if (char.IsLetter(c) && !char.IsUpper(c))
                    return false;
            return true;
        }

        public void setSurname(String s)
        {
            if (IsAllUpper(s))
            {
                surname = s;
            }
            else
            {
                Console.WriteLine("Surname is not in all caps");
            }
        }

        public void setDepartment(char c)
        {
            if (c.Equals('E')|| c.Equals('e'))
            {
                departName = "Electronics";
            } 
            else if(c.Equals('H')|| c.Equals('h'))
            {
               departName = "Hardware";
            }
            else if (c.Equals('S')|| c.Equals('s'))
            {
                departName = "Sportsware";
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public void setSales(double s)
        {
            if(s < 2000)
            {
                sales = 2000;
            }
            else
            {
                sales = s;
            }
        }

        public double calcSalary()
        {
            const double basicSal = 3000;
            double commission = 0.0;

            if (departName.Equals("Electronics"))
            {
                commission = 0.035;
            } 
            else if (departName.Equals("Hardware"))
            {
                commission = 0.02;
            }
            else if (departName.Equals("Sportsware"))
            {
                commission = 0.045;
            }

            return (sales * commission) + basicSal;
        }
        
        public String getName()
        {
            return name;
        }

        public String getSurname()
        {
            return surname;
        }

        public String getDerpartment()
        {
            return departName;
        }   
    }
}
