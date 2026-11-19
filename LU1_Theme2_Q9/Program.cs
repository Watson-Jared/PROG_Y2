namespace LU1_Theme2_Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum: " + calcSum(num1, num2));
            Console.WriteLine("Product: " + calcProduct(num1, num2));
            Console.WriteLine("Average: " + calcAvg(num1, num2));

            Console.ReadKey();
        }

        static int calcSum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int calcProduct(int num1, int num2)
        {
            return num1 * num2;
        }

        static int calcAvg(int num1, int num2)
        {
            return (num1 + num2) / 2;
        }

    }
}
