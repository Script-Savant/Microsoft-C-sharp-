namespace FirstDemoHello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello Compatriates! How is the going?");

            app.Run();
        }
    }
}