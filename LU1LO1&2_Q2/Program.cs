namespace LU1LO1_2_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextFileReader file = new TextFileReader("TextFile1.txt");

            file.readAllText();
            file.readLine();
            file.Dispose();
            
        }
    }
}
