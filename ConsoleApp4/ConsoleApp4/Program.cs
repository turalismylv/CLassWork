using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("tural"));

        }
        static string ReverseString(string name)
        {

            string reversedName = "";
            for (int i = name.Length-1; i >=0; i--)
            {

                reversedName += name[i];
                
            }
            return reversedName;
        }
            
    }
}
