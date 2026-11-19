namespace LU1LO1_2_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempFileTracker data1 = new TempFileTracker("data1.txt");
            TempFileTracker data2 = new TempFileTracker("data2.txt");
            TempFileTracker data3 = new TempFileTracker("data3.txt");

            data1.WriteContent("data1");
            data2.WriteContent("data2");
            data3.WriteContent("data3");

            data1 = null;
            data2 = null;
            data3 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();           

            Console.ReadKey();
        }
    }
}
