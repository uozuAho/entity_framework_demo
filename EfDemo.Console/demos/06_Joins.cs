using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EfDemo.Console.demos
{
    class _06_Joins
    {
        public static void Run()
        {
            // SelectMovieSales();
            // LazyLoading_BoxOfficeNotIncluded();
            // LazyLoading_BoxOfficeIncluded();
            LazyLoadBoxOffice();
        }

        private static void SelectMovieSales()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            var sales = dbContext.Movies
                .Include(movie => movie.BoxOffices)
                .Select(movie => new
                {
                    movie.Title,
                    movie.BoxOffices
                }).First();

            ConsoleUtils.PrintAsJson(sales);
        }

        private static void LazyLoading_BoxOfficeNotIncluded()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            var movie = dbContext.Movies.First();

            ConsoleUtils.PrintAsJson(movie);
            ConsoleUtils.PrintAsJson(movie.BoxOffices);
        }

        private static void LazyLoading_BoxOfficeIncluded()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            var movie = dbContext.Movies.Include(m => m.BoxOffices).First();

            ConsoleUtils.PrintAsJson(movie);
            ConsoleUtils.PrintAsJson(movie.BoxOffices);
        }

        private static void LazyLoadBoxOffice()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true, useLazyLoading: true);

            var movie = dbContext.Movies.First();

            ConsoleUtils.PrintAsJson(movie);
            ConsoleUtils.PrintAsJson(movie.BoxOffices.First());
        }
    }
}
