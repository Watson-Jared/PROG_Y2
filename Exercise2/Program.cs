using System.Security.Cryptography;

namespace Exercise2
{

    public class SimpleRescource : IDisposable
    {
        private bool disposed = false;
        private string name;

        public SimpleRescource(string n)
        {
            name = n;
            Console.WriteLine("Resource '" + name + "' created");
        }

        public void UseResource()
        {
            if (disposed)
            {

                Console.WriteLine("ERROR: Resource '" + name + "' already disposed!");
                return;
            }

            Console.WriteLine("Using resource '" + name + "'");
        }

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine("Resource '" + name + "' disposed");
                disposed = true;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("===== Basic Disposble ====\n");
                SimpleRescource re = new SimpleRescource("Resource 1");

                re.UseResource();
                re.Dispose();
                re.UseResource();

                Console.WriteLine("End Program");
              

            }

        }
    }
}
