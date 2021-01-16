using EfDemo.Db;
using Microsoft.EntityFrameworkCore;

namespace EfDemo.Console
{
    internal class ConsoleEfDemoContext : EfDemoContext
    {
        private readonly bool _logQueries;

        public ConsoleEfDemoContext(bool logQueries = false)
        {
            _logQueries = logQueries;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString =
                "Server=localhost;Port=5432;Database=ef-demo-db;User Id=postgres;Password=postgres;";

            optionsBuilder.UseNpgsql(connectionString);
                
            if (_logQueries)
            {
                optionsBuilder
                    .EnableSensitiveDataLogging()
                    .LogTo(System.Console.WriteLine);
            }
        }
    }
}
