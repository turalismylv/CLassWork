﻿using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getStatus("level"));

        }
        public static bool getStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }

    }
}

