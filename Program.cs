namespace LU2_Theme1_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            TextBook textBook = new TextBook();

            book.setTitle("Moby Dick");
            book.setNumOfPages(99);
            textBook.setTitle("Peter Pan");
            textBook.setNumOfPages(70);
            textBook.setGradeLvl(3);

            Console.WriteLine("Book Title: " + book.getTitle() +
                "\nNumber of Pages: " + book.getNumOfPages());

            Console.WriteLine("\nTextbook Title: " + textBook.getTitle() +
                "\nNumber of Pages: " + textBook.getNumOfPages()+
                "\nGrade Level: " + textBook.getGradeLvl());

            Console.ReadKey();
        }
    }
}
