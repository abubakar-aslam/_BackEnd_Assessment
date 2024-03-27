using Microsoft.EntityFrameworkCore;
using System.Text;

namespace _BackEnd_Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));
            var app = builder.Build();

            // Populate tables
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                dbContext.PopulateUserTable();
                dbContext.SaveChanges();
                dbContext.PopulateContentTableWithImages();
                dbContext.SaveChanges();
                dbContext.PopulateNetworkTable();
                dbContext.SaveChanges();
            }

            app.MapGet("/", (AppDbContext dbContext) =>
            {

                // query to display users by wins in desc order
                var users = dbContext.Users
                    .OrderByDescending(u => u.Wins)
                    .ToList();

                // Display result to user on web
                var sb = new StringBuilder();
                sb.AppendLine("<h1>Users Ordered by Wins</h1>");
                sb.AppendLine("<ul>");
                foreach (var user in users)
                {
                    sb.AppendLine($"<li>{user.UserName} - Wins: {user.Wins}</li>");
                }
                sb.AppendLine("</ul>");

                return sb.ToString();
            });
            app.Run();
        }
    }
}