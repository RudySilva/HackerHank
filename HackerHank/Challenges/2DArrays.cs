using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class _2DArrays
    {
        private static int GetMaxHourGlassSum(int[][] arr)
        {
            int max = 0;
            int[] arrSum = new int[7];
            int sum = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arrSum[0] = arr[i][j];
                    arrSum[1] = arr[i][j + 1];
                    arrSum[2] = arr[i][j + 2];
                    arrSum[3] = arr[i + 1][j + 1];
                    arrSum[4] = arr[i + 2][j];
                    arrSum[5] = arr[i + 2][j + 1];
                    arrSum[6] = arr[i + 2][j + 2];

                    Console.Write(arr[i][j]);
                    Console.Write(arr[i][j + 1]);
                    Console.WriteLine(arr[i][j + 2]);
                    Console.WriteLine(" " + arr[i + 1][j + 1].ToString() + " ");
                    Console.Write(arr[i + 2][j]);
                    Console.Write(arr[i + 2][j + 1]);
                    Console.WriteLine(arr[i + 2][j + 2]);
                    Console.WriteLine("_");

                    for (int k = 0; k < 7; k++)
                        sum += arrSum[k];

                    Console.WriteLine("sum = " + sum.ToString());

                    if (i == 0 && j == 0)
                        max = sum;

                    if (sum > max)
                        max = sum;

                    sum = 0;
                }
                Console.WriteLine("|");
                

                
            }
            Console.WriteLine("max = " + max.ToString());

            return max;

        }


        public static void Execute()
        {
            int[][] arr = new int[6][];
            string[] input = new string[6];
            //test case 1
            input[0] = "-1 -1 0 -9 -2 -2";
            input[1] = "-2 -1 -6 -8 -2 -5";
            input[2] = "-1 -1 -1 -2 -3 -4";
            input[3] = "-1 -9 -2 -4 -4 -5";
            input[4] = "-7 -3 -3 -2 -9 -9";
            input[5] = "-1 -3 -1 -2 -4 -5";

            //result = -6

            //test case 0
            //input[0] = "1 1 1 0 0 0";
            //input[1] = "0 1 0 0 0 0";
            //input[2] = "1 1 1 0 0 0";
            //input[3] = "0 0 2 4 4 0";
            //input[4] = "0 0 0 2 0 0";
            //input[5] = "0 0 1 2 4 0";

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(input[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }


            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}

            Console.WriteLine(GetMaxHourGlassSum(arr));


        }
    }
    
}
