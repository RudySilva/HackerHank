using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank { 
    //Day 6
    class Review
    {
        public static void Execute()
        {
            int t = int.Parse(Console.ReadLine());
            for (int j = 0; j < t; j++)
            {
                string word = Console.ReadLine();
                string evenIndex = string.Empty;
                string oddIndex = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenIndex += word.Substring(i, 1);
                    }
                    else
                    {
                        oddIndex += word.Substring(i, 1);
                    }
                }
                Console.WriteLine(evenIndex + " " + oddIndex);
                
            }
        }
    }
}
