using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    internal class RunEmployee
    {
        
        public static void populate(Employee[] emp)
        {
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
                Console.WriteLine("\nEnter Employee "+ (i+1)+" Name: ");
                emp[i].setName(Console.ReadLine());
                Console.WriteLine("Enter Employee " + (i + 1) + " Surname: ");
                emp[i].setSurname(Console.ReadLine());
                Console.WriteLine("Enter Employee " + (i + 1) + " Department First Letter: ");
                emp[i].setDepartment(char.Parse(Console.ReadLine()));
                Console.WriteLine("Enter Employee " + (i + 1) + " salary: ");
                emp[i].setSales(double.Parse(Console.ReadLine()));
            }
        }

        public static void display(Employee[] emp)
        {
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("Employee " + (i+1) + " Name " + emp[i].getName);
                Console.WriteLine("Employee " + (i + 1) + " Surname " + emp[i].getSurname);
                Console.WriteLine("Employee " + (i + 1) + " Department " + emp[i].getDerpartment);
                Console.WriteLine("Employee " + (i + 1) + " Salary " + emp[i].calcSalary);
                Console.WriteLine("------------------------------------------\n");
            }
        }
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[1];
            populate(emp);

            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("Employee " + (i + 1) + " Name " + emp[i].getName());
                Console.WriteLine("Employee " + (i + 1) + " Surname " + emp[i].getSurname());
                Console.WriteLine("Employee " + (i + 1) + " Department " + emp[i].getDerpartment());
                Console.WriteLine("Employee " + (i + 1) + " Salary " + emp[i].calcSalary());
                Console.WriteLine("------------------------------------------\n");
            }



            Console.ReadKey();
        }
    }
}
