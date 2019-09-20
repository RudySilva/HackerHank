using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class Arrays
    {
        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            string result = string.Empty;

            for (int i = arr.Length -1; i >= 0 ; i--)
            {
                result += arr[i].ToString() + " ";
            }
            Console.WriteLine(result);
        }
    }
}
