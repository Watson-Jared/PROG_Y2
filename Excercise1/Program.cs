namespace Excercise1
{

    public class Person
    {
        private string _name;
        private int _age;

        public Person(string n, int a ) {

            _name = n;
            _age = a;
            Console.WriteLine($"Person {_name} created");
        }

        ~Person() {
            Console.WriteLine($"Person {_name}  is eing destroyed!");
            Console.WriteLine($"Age was: {_age}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p1 = new Person("john", 25);
           Person p2 = new Person("Sarah", 30);

            p1 = null;
            p2 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Main program ending");
        }
    }
}
