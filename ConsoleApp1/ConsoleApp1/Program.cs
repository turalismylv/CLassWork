using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iki eded daxil edin: ");
            string NumStr1 = Console.ReadLine();
            string NumStr2 = Console.ReadLine();
                int Num2 = int.Parse(NumStr2);
            int Num1 = int.Parse(NumStr1);

            Num(Num1, Num2);


        }
        static void Num(int a,int b) {
            int Num = a + b;
            Console.WriteLine(Num);
      }

    }
}
