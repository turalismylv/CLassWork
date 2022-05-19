using System;

namespace ConsoleApp2
{
    class Program
    {


        static void PrintSquare(int en, int hundurluk)
        {
            for (int i = 0; i < en; i++)
            {

                for (int j = 0; j < hundurluk; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
