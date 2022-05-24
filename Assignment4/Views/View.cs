using System;
using System.Collections.Generic;

namespace Assignment4
{
    public class View
    {
        public static void PrintAllTShirts(List<TShirt> shirts, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.WriteLine($"{"Size",-15}{"Color",-15}{"Fabric",-15}");
            Console.ResetColor();

            foreach (var shirt in shirts)
            {
                Console.WriteLine($"{shirt.Size,-15}{shirt.Color,-15}{shirt.Fabric,-15}");
            }
        }
    }
}
