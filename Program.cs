namespace InheriteEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();

            programmer.Name = "John";
            programmer.Surname = "Doe";
            programmer.Rate = 50.0;
            programmer.Hours = 40;

            Console.WriteLine(programmer.ToString()); 

            Console.ReadKey();
        }
    }
}
