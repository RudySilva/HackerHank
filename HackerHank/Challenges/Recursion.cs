using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerHank
{
    class Recursion
    {
        static int factorial(int n)
        {
            if (n <= 0)
                return 1;
            else
                return n * factorial(n - 1);

        }
        public static void Execute()
        {
            //Environment.SetEnvironmentVariable("OUTPUT_PATH", "@C:\\test\\test.txt");
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            TextWriter textWriter = new StreamWriter(@"C:\test\test.txt", true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            textWriter.WriteLine(result.ToString());

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
