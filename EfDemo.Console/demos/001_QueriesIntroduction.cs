using System.Linq;

namespace EfDemo.Console.demos
{
    class _01_QueriesIntroduction
    {
        public static void Run()
        {
            // SelectTitle();
            // SelectTitleAndDirector();
            SelectAll();
        }

        private static void SelectTitle()
        {
            using var dbContext = new ConsoleEfDemoContext();

            ConsoleUtils.PrintAsJson(dbContext.Movies.Select(movie => new
            {
                movie.Title
            }));
        }

        private static void SelectTitleAndDirector()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries:true);

            ConsoleUtils.PrintAsJson(dbContext.Movies.Select(movie => new
            {
                movie.Title,
                movie.Director
            }));
        }

        private static void SelectAll()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries:true);

            ConsoleUtils.PrintAsJson(dbContext.Movies);
        }
    }
}
