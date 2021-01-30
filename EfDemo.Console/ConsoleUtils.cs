using System.Text.Json;
using System.Text.Json.Serialization;

namespace EfDemo.Console
{
    internal class ConsoleUtils
    {
        public static void Print(string message = null)
        {
            System.Console.WriteLine(message);
        }

        public static void PrintAsJson(object obj)
        {
            Print(JsonSerializer.Serialize(obj, new JsonSerializerOptions
            {
                WriteIndented = true,
                // ReferenceHandler = ReferenceHandler.Preserve
            }));
        }
    }
}
