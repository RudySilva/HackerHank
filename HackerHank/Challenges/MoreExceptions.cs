using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class Calculator
    {
        public int power(int n, int p)
        {
            //int result = 0;

            if (n >= 0 && p >= 0)
            {
                return Convert.ToInt32(Math.Pow(n, p));
                //for (int i = 1; i < p ; i++)
                //{
                //    if (result.Equals(0))
                //        result = n * n;
                //    else
                //        result *= n;
                //}
            }
            else
                throw new Exception("n and p should be non-negative");

            //return result;
        }
    }
    class MoreExceptions
    {
        

        public static void Execute()
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }



        }
    }
}
