using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EfDemo.Console.demos
{
    class _06_Joins
    {
        public static void Run()
        {
            SelectMovieSales();
        }

        private static void SelectMovieSales()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            var sales = dbContext.Movies
                .Include(movie => movie.BoxOffices)
                .Select(movie => new
                {
                    movie.Title,
                    movie.BoxOffices.First().DomesticSales,
                    movie.BoxOffices.First().InternationalSales
                }).ToList();

            ConsoleUtils.PrintAsJson(sales);
        }
    }
}
