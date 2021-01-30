using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EfDemo.Console.demos
{
    class _100_LazyEagerLoading
    {
        public static void Run()
        {
            // BoxOfficeNotIncluded();
            // EagerLoadBoxOffice();
            LazyLoadBoxOffice();
        }

        private static void BoxOfficeNotIncluded()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            var movie = dbContext.Movies.First();

            ConsoleUtils.PrintAsJson(movie);
        }

        private static void EagerLoadBoxOffice()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            var movie = dbContext.Movies.Include(m => m.BoxOffices).First();

            ConsoleUtils.PrintAsJson(movie);
        }

        private static void LazyLoadBoxOffice()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true, useLazyLoading: true);

            var movie = dbContext.Movies.First();

            ConsoleUtils.PrintAsJson(movie);
        }
    }
}
