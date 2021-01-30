using Microsoft.EntityFrameworkCore;

namespace EfDemo.Console.demos
{
    class _99_RawSql
    {
        public static void Run()
        {
            RawSql();
        }

        private static void RawSql()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries:true);

            var sortedNames = dbContext.Movies.FromSqlRaw(
                "select * from movies where title like 'Toy%'");

            ConsoleUtils.PrintAsJson(sortedNames);
        }
    }
}
