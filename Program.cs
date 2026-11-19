namespace LU1_Theme2_Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            populate(array);
            Console.WriteLine("Average of array: " + calculateAverage(array) + "\nHighest Number in the array is: " + findHighest(array)
                +"\nLowest Number in the array is: " + findLowest(array));

            Console.ReadKey();
        }

        static void populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a Number");
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
        }

        static int calculateAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum/ arr.Length;
        }

        static int findHighest(int[] arr)
        {
            int high = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > high)
                {
                    high = arr[i];
                }
            }

            return high; 
        }

        static int findLowest(int[] arr)
        {
            int low = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < low)
                {
                    low = arr[i];
                }
            }
            return low;
        }
    }
}
