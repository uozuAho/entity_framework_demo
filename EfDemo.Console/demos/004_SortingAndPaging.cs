using System.Linq;

namespace EfDemo.Console.demos
{
    class _04_SortingAndPaging
    {
        public static void Run()
        {
            // SelectDistinctDirectors_Sorted();
            // SelectLastFourMovies();
            SelectNextFiveMovies();
        }

        private static void SelectDistinctDirectors_Sorted()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries:true);

            var sortedDirectors = dbContext.Movies
                .Select(movie => new
                {
                    movie.Director
                })
                .Distinct()
                .OrderBy(movie => movie.Director);

            ConsoleUtils.PrintAsJson(sortedDirectors);
        }

        private static void SelectLastFourMovies()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries:true);

            var last4Movies = dbContext.Movies
                .Select(movie => new
                {
                    movie.Title,
                    movie.Year
                })
                .OrderByDescending(movie => movie.Year)
                .Take(4);

            ConsoleUtils.PrintAsJson(last4Movies);
        }

        private static void SelectNextFiveMovies()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries:true);

            var last4Movies = dbContext.Movies
                .Select(movie => new
                {
                    movie.Title,
                })
                .OrderBy(movie => movie.Title)
                .Skip(5)
                .Take(5);

            ConsoleUtils.PrintAsJson(last4Movies);
        }
    }
}
