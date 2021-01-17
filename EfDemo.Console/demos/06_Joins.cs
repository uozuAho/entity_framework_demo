namespace EfDemo.Console.demos
{
    class _06_Joins
    {
        public static void Run()
        {
            SelectDistinctDirectors_Sorted();
        }

        private static void SelectDistinctDirectors_Sorted()
        {
            using var dbContext = new ConsoleEfDemoContext(logQueries: true);

            var sales = dbContext.BoxOffices;

            ConsoleUtils.PrintAsJson(sales);
        }
    }
}
