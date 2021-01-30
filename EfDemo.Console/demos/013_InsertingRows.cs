using EfDemo.Db;

namespace EfDemo.Console.demos
{
    class _13_InsertingRows
    {
        public static void Run()
        {
            AddMovie();
        }

        private static void AddMovie()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            dbContext.Movies.Add(new Movie
            {
                Title = "Forrest Gump",
                Director = "Robert Zemeckis",
                Year = 1994,
                LengthMinutes = 142
            });

            dbContext.SaveChanges();
        }
    }
}
