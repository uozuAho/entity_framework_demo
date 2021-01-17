using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EfDemo.Console.demos
{
    class _06_Joins
    {
        public static void Run()
        {
            // SelectMovieSales();
            EagerLoading();
        }

        private static void SelectMovieSales()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            var sales = dbContext.Movies
                .Include(movie => movie.BoxOffice)
                .Select(movie => new
                {
                    movie.Title,
                    movie.BoxOffice.DomesticSales,
                    movie.BoxOffice.InternationalSales
                });

            ConsoleUtils.PrintAsJson(sales);
        }

        private static void EagerLoading()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            var movies = dbContext.Movies.Take(3).ToList();
            // boom!
            // var sales = movies.Select(movie => movie.BoxOffice.DomesticSales).ToList();

            // var movies2 = dbContext.Movies.Include(m => m.BoxOffice).Take(3).ToList();
            // var sales2 = movies2.Select(movie => movie.BoxOffice.DomesticSales).ToList();

            ConsoleUtils.PrintAsJson(movies);
        }
    }
}
