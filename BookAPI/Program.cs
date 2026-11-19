using BookLibrary;
using Microsoft.EntityFrameworkCore;


namespace BookAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);       

            builder.Services.AddControllers();       
            builder.Services.AddSingleton<BookService>();


            var app = builder.Build();

           

           
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
