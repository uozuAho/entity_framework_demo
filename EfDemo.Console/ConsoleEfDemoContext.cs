using EfDemo.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfDemo.Console
{
    internal class ConsoleEfDemoContext : EfDemoContext
    {
        private readonly bool _logQueries;
        private readonly bool _useLazyLoading;

        public ConsoleEfDemoContext(bool logQueries = false, bool useLazyLoading = false)
        {
            _logQueries = logQueries;
            _useLazyLoading = useLazyLoading;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString =
                "Server=localhost;Port=5432;Database=ef-demo-db;User Id=postgres;Password=postgres;";

            optionsBuilder.UseNpgsql(connectionString);

            if (_useLazyLoading)
            {
                optionsBuilder.UseLazyLoadingProxies();
            }

            if (_logQueries)
            {
                optionsBuilder
                    .EnableSensitiveDataLogging()
                    .LogTo(System.Console.WriteLine, LogLevel.Information);
            }
        }
    }
}
