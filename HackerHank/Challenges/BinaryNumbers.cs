using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class BinaryNumbers
    {
        //method count the maximum of numbers 1 in sequence
        private static int SumOnesBinary(int n)
        {
            string binary = Convert.ToString(n, 2);
            int sum;
            int max = 0;
            int j = 0;

            while (j <= binary.Length -1)
            {
                sum = 0;
                if (binary.Substring(j, 1).Equals("1"))
                {
                    sum = 1;
                    j += 1;
                    while (j <= binary.Length - 1)
                    {
                        if (binary.Substring(j, 1).Equals("1"))
                            sum += 1;
                        else
                            sum = 0;

                        if (sum > max)
                            max = sum;

                        j += 1;
                    }
                }
            }
            return max;
        }

        public static void Execute()
        {
            int n;
            int max = 0;
            while (max == 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
                max = SumOnesBinary(n);
                Console.WriteLine(max);
                max = 0;

            }

        }
    }
}
