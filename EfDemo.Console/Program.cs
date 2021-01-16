namespace EfDemo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new ConsoleEfDemoContext();

            ConsoleUtils.PrintAsJson(db.Movies);
        }
    }
}
