using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerHank
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            this.elements = a;
        }

        public int computeDifference()
        {
            maximumDifference = 0;
            int difference;
            int highest;
            int lowest;
            for (int i = 0; i < elements.Length; i++)
            {
                difference = 0;
                for (int j = 0; j < elements.Length; j++)
                {
                    if (i != j)
                    {
                        if (elements[i] > elements[j])
                        {
                            highest = elements[i];
                            lowest = elements[j];
                        }
                        else
                        {
                            highest = elements[j];
                            lowest = elements[i];
                        }

                        difference = highest - lowest;

                        if (maximumDifference < difference)
                            maximumDifference = difference;
                    }

                }
            }
            return maximumDifference;
        }

    } 

    class Scope
    {
        public static void Execute()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
