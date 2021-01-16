using System.Linq;

namespace EfDemo.Console.demos
{
    class _02_QueryWithConstraints
    {
        public static void Run()
        {
            // SelectMovie6();
            Select2000sMovies();
        }

        private static void SelectMovie6()
        {
            using var dbContext = new ConsoleEfDemoContext();

            var marges = dbContext.Movies
                .Where(movie => movie.Id == 6)
                .Select(movie => new
                {
                    movie.Title
                });

            ConsoleUtils.PrintAsJson(marges);
        }

        private static void Select2000sMovies()
        {
            using var dbContext = new ConsoleEfDemoContext();

            var marges = dbContext.Movies
                .Where(movie => movie.Year >= 2000 && movie.Year < 2010)
                .Select(movie => new
                {
                    movie.Title
                });

            ConsoleUtils.PrintAsJson(marges);
        }
    }
}
