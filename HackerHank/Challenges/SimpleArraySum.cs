using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerHank
{
    class SimpleArraySum
    {
        
         // Complete the simpleArraySum function below.
        static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }

            return sum;

        }
    
        public static void Execute()
        {
        
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            TextWriter textWriter = new StreamWriter(@"C:\test\test.txt", true);
            int arCount = Convert.ToInt32(Console.ReadLine());


            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        
    }
}
