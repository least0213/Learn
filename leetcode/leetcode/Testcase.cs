using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class Testcase
    {

        /// <summary>
        /// 70. Climbing Stairs
        /// </summary>
        public void tc70()
        {
            int input = 10;
            Problem test = new Problem();
            int result = test.ClimbStairs(input);
            Console.Write(result);
        }

        /// <summary>
        /// 121. Best Time to Buy and Sell Stock
        /// </summary>
        public void tc121()
        {
            int[] input = { 7, 1, 5, 3, 6, 4 };
            Problem test = new Problem();
            //int result = test.MaxProfit(input);
            int result = test.MaxProfitOpt(input);
            Console.Write(result);
        }

        /// <summary>
        /// 268. Missing Number
        /// </summary>
        public void tc268()
        {
            Question myQ = new Question();
            int[] input1 = { 3, 0, 1 };
            for (int i =0; i<input1.Length; i++)
            {
                Console.Write(input1[i] + " ");
            }
            Console.WriteLine("\n" + myQ.MissingNumber(input1) + "\n");
            int[] input2 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            for (int i = 0; i < input2.Length; i++)
            {
                Console.Write(input2[i] + " ");
            }
            Console.WriteLine("\n" + myQ.MissingNumber(input2));
        }

        /// <summary>
        /// 387. First Unique Character in a String
        /// </summary>
        public void tc387()
        {
            Question myQ = new Question();
            string s1 = "leetcode";
            Console.WriteLine(s1);
            Console.WriteLine(myQ.FirstUniqChar(s1));
            string s2 = "loveleetcode";
            Console.WriteLine(s2);
            Console.WriteLine(myQ.FirstUniqChar(s2));
        }

        /// <summary>
        /// 443. String Compression
        /// </summary>
        public void tc443()
        {
            Question myQ = new Question();
            char[] input1 = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c'};
            char[] input2 = new char[] { 'a'};
            char[] input = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            for (int i = 0; i< input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine("\n" + myQ.Compress(input));
        }

        /// <summary>
        /// 448. Find All Numbers Disappeared in an Array
        /// </summary>
        public void tc448()
        {
            Question myQ = new Question();
            int[] input = { 4, 3, 2, 7, 8, 2, 3, 1 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine("\n");
            IList<int> output = myQ.FindDisappearedNumbers(input);
            foreach (int r in output)
            {
                Console.Write(r + " ");
            }
        }

        /// <summary>
        /// 819. Most Common Word
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public void tc819()
        {
            Question myQ = new Question();
            //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string paragraph = "Bob";
            Console.WriteLine(paragraph);
            string[] banned = {"hit"};
            Console.WriteLine(myQ.MostCommonWord(paragraph, banned));
        }

        /// <summary>
        /// 867. Transpose Matrix
        /// </summary>
        public void tc867()
        {
            int[][] input = new int[3][];
            input[0] = new int[3] { 1, 2, 3 };
            input[1] = new int[3] { 4, 5, 6 };
            input[2] = new int[3] { 7, 8, 9 };
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[0].Length; j++)
                {
                    Console.Write(input[i][j] + " ");
                }
                Console.Write("\n");
            }
            Problem test = new Problem();
            int[][] result = test.Transpose(input);
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[0].Length; j++)
                {
                    Console.Write(result[i][j] + " ");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// 905. Sort Array By Parity
        /// </summary>
        public void tc905()
        {
            int[] input = { 3, 1, 2, 4, 7, 8 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Problem test = new Problem();
            int[] output = test.SortArrayByParity(input);
            Console.WriteLine();
            for (int j = 0; j < input.Length; j++)
            {
                Console.Write(output[j] + " ");
            }
        }

        public void tc977()
        {
            int[] input = { -4, -1, 0, 3, 10 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Problem test = new Problem();
            int[] output = test.SortedSquares(input);
            Console.WriteLine();
            for (int j = 0; j < input.Length; j++)
            {
                Console.Write(output[j] + " ");
            }
        }
    }
}
