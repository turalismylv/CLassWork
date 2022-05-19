using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSquare(5,5);
        }
        static void PrintSquare(int en, int hundurluk)
        {
            for (int i = 0; i < en; i++)
            {

                for (int j = 0; j < hundurluk; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}
