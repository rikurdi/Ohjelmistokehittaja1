using System;

namespace Harjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teht 1
            int x;
            int y;

            Console.WriteLine("Syötä luku 1: ");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä luku 2: ");
            y = Int32.Parse(Console.ReadLine());
            Console.WriteLine(x = y + 3);

            //Teht 2
            int a;
            int b;

            Console.WriteLine("Syötä luku 1: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä luku 2: ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(a = b - 3);

        }
    }
}