using System.Diagnostics; 
namespace ASPExample01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () =>
            //{
            //    var process = Process.GetCurrentProcess();

            //    return $"Hello World:\n" +
            //    $"Process Name: {process.ProcessName}\n" +
            //    $"Process Id: {process.Id}\n" +
            //    $"Start Time: {process.StartTime}\n" +
            //    $"Memory Usage: {process.WorkingSet64}\n" +
            //    $"CPU Time: {process.TotalProcessorTime}\n";

            //});

            app.MapGet("/", async (HttpContext context) =>
            {
                var process = Process.GetCurrentProcess();

                context.Response.ContentType = "text/html";
                await context.Response.WriteAsync($@"          
                <h1>HelloWorld!</h1>
                 <ul>
                 <li>Process Name {process.ProcessName}</li>
                 <li>Process ID {process.Id}</li>
                 <li>Start Time {process.StartTime}</li>
                 <li>Memory {process.WorkingSet64 /1024/1024}</li>
                 <li>CPU Time {process.TotalProcessorTime}</li>
                 </ul>
                ");
            });

            app.Run();
        }
    }
}
