using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class NewCalculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            List<int> factors = new List<int>();
            int i = n;
            int sum = 0;
            while (i >= 1)
            {
                if (n % i == 0)
                    factors.Add(i);

                i -= 1;
            }
            
            foreach (var item in factors)
                sum += item;

            return sum;
        }
    }

    class Interfaces
    {
        public static void Execute()
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new NewCalculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
