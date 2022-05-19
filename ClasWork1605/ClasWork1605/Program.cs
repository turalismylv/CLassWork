using System;

namespace ClasWork1605
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 11;
            //double b=ChangeDouble(ref  a);
            Console.WriteLine(ChangeDouble(ref  a));
        }

        static double ChangeDouble(ref double a) {

              a=13;
            return a;
        }
    }
}
