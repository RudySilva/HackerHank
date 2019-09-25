using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class ExceptionStringToInt
    {
        public static void Execute()
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(Convert.ToInt32(S));
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
                throw;
            }
        }
    }
}
