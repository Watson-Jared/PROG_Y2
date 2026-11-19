namespace LU1_Theme2_Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static int mathOperations(int a, int b, int c)
        {
            int large = 0;

            for (int i = 0; i < 4; i++)
            {
                if(a > b)
                {
                    if (c > large)
                    {
                        large = c;
                    }
                    large = a;
                }
                else
                {
                    if (c > large)
                    {
                        large = c;
                    }
                    large = b;
                }

                return large;

            }

        }
    }
}
