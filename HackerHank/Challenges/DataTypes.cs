﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class DataTypes
    {
         public static void Execute()
         {
             int i = 4;
             double d = 4.0;
             string s = "HackerRank ";

             // Declare second integer, double, and String variables.

             // Read and save an integer, double, and String to your variables.

             // Print the sum of both integer variables on a new line.

             // Print the sum of the double variables on a new line.

             // Concatenate and print the String variables on a new line
             // The 's' variable above should be printed first.

             int j = Convert.ToInt32(Console.ReadLine());
             double e = Convert.ToDouble(Console.ReadLine());
             string o = Console.ReadLine().ToString();

             Console.WriteLine(i+j);
             Console.WriteLine(string.Format("{0:0.0}", d + e));
             Console.WriteLine(s + o);
         }
    }
}
