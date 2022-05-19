using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsPolindrome(1458));
        }
        static bool IsPolindrome(int number)
        {
            int  x, sum = 0, y;
            y = number;

            while (number > 0)
            {
                x = number % 10;
                sum = (sum * 10) + x;
                number = number / 10;
            }
            return y == sum;

                
                
            }

        }
}

