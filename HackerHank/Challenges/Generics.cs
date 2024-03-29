﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class Generics
    {
        static void PrintArray<T>(ICollection<T> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);
        }
    }
}
