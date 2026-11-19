namespace LU1_Theme2_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(isEven(number));

            Console.ReadKey();
        }

        static String isEven(int num)
        {
            if (num % 2 == 0)
            {
                return "Number is Even";
            }
            else
            {
                return "Number is Odd";
            }
        }

    }
}
