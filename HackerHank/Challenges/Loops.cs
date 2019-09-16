using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    //Day 5
    class Loops
    {
        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result;

            for (int i = 1; i <= 10; i++)
            {
                result = n * i;
                Console.WriteLine(n.ToString() + " x " + i.ToString() + " = " + result.ToString());

            }
        }
    }
}
