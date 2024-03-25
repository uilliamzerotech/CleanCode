using Microsoft.EntityFrameworkCore;
using Model.Context;

namespace View
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<DataBaseContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("CONEXAO")));
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
