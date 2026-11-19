namespace LU1_Theme2_Q1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            inputNumber();
            Console.WriteLine(seperateNumber(inputNumber()));
            
        }

        static String inputNumber()
        {
            Console.WriteLine("Enter number");
            String number = Console.ReadLine();
            return number;
        }

        static String seperateNumber(String n)
        {
            if ( n.Length > 10)
            {
                return "Enter Number Less than ten character: " + inputNumber();
            }
            else if (n.Equals("999"))
            {
                return "Exit Application";
            }
            else
            {
                return n;
            }
        }
    }
}
