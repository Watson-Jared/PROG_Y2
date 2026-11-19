namespace LU1_Theme2_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Degrees Farenhiet: " + celsiusToFarenhiet(userInput()));
            Console.ReadKey();
        }

        static double userInput()
        {
            Console.WriteLine("Enter Tempereture in Celsius");
            double temp = double.Parse(Console.ReadLine());
            return temp;
        }

        static double celsiusToFarenhiet(double t)
        {
            return (t * 1.8) + 32;
        }
    }
}
