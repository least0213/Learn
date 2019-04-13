using System;
using System.Linq;
using System.Collections.Generic;
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestQuestions
{
    [TestClass]
    public class UnitTestQuestions
    {
        /// <summary>
        /// 20. Valid Parentheses
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Stack")]
        [Priority(2)]
        public void TestMethod20()
        {
            string input1 = "()[]{}";
            string input2 = "([)]";
            bool expected = true;

            Question test = new Question();
            bool actual = test.IsValid(input1);
            Console.Write(actual);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 53. Maximum Subarray
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Dynamic Programming")]
        [Priority(2)]
        public void TestMethod53()
        {
            int[] input1 = {-2, 1, -3, 4, -1, 2, 1, -5, 4 , 7};
            int[] input = { -2, -1 };
            int expected = 12;

            Question test = new Question();
            int actual = test.MaxSubArray(input1);

            Console.Write(actual);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 66. Plus One
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod66()
        {
            int[] input = { 9, 9 };
            int[] expected = { 1, 0, 0};
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();

            Question myQ = new Question();
            int[] actual = myQ.PlusOne(input);
            for (int i = 0; i < actual.Length; i++)
            {
                Console.Write(actual[i] + " ");
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 70. Climbing Stairs
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Dynamic Programming")]
        [Priority(2)]
        public void TestMethod70()
        {
            int input = 10;
            int expected = 89;

            Question test = new Question();
            int actual = test.ClimbStairs(input);

            Console.Write(actual);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 121. Best Time to Buy and Sell Stock
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Dynamic Programming")]
        [Priority(2)]
        public void TestMethod121()
        {
            int[] input = { 7, 1, 5, 3, 6, 4 };
            int expected = 5;

            Question test = new Question();
            //int result = test.MaxProfit(input);
            int actual = test.MaxProfitOpt(input);

            Console.Write(actual);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 125. Valid Palindrome
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod125()
        {
            string input1 = "A man, a plan, a canal: Panama";
            string input2 = "race a car";
            string input3 = "0P";
            bool expect = false;

            Question test = new Question();
            bool actual = test.IsPalindromeOpt(input3);

            Console.Write(actual);
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// 238. Product of Array Except Self
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod238()
        {
            int[] input = { 1, 2, 3, 4 };
            int[] expected = { 24, 12, 8, 6 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();

            Question test = new Question();
            //int result = test.MaxProfit(input);
            int[] actual = test.ProductExceptSelf(input);

            for (int i = 0; i < actual.Length; i++)
            {
                Console.Write(actual[i] + " ");
            }
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 268. Missing Number
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod268()
        {
            int[] input1 = { 3, 0, 1 };
            int[] input2 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int expected1 = 2;
            int expected2 = 8;

            for (int i = 0; i < input1.Length; i++)
            {
                Console.Write(input1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < input2.Length; i++)
            {
                Console.Write(input2[i] + " ");
            }

            Question myQ = new Question();
            int actual1 = myQ.MissingNumber(input1);
            int actual2 = myQ.MissingNumber(input2);
            Console.WriteLine("\n" + actual1);
            Console.WriteLine(actual2);


            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        /// <summary>
        /// 303. Range Sum Query - Immutable
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Dynamic Programming")]
        [Priority(2)]
        public void TestMethod303()
        {
            int[] input = { -2, 0, 3, -5, 2, -1 };
            NumArray test = new NumArray(input);
            //int[] sumList = test.NumArray(input);
            int result = test.SumRange(0, 2);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 345. Reverse Vowels of a String
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod345()
        {
            string input = "leetcode";
            Console.WriteLine("input string is : {0}", input);
            Console.WriteLine("expect output string is : leotcede");
            Question myQ = new Question();
            Console.WriteLine("actual output string is : {0}", myQ.ReverseVowels(input));
        }

        /// <summary>
        /// 387. First Unique Character in a String
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod387()
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
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod443()
        {
            Question myQ = new Question();
            char[] input1 = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            char[] input2 = new char[] { 'a' };
            char[] input = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine("\n" + myQ.Compress(input));
        }

        /// <summary>
        /// 448. Find All Numbers Disappeared in an Array
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod448()
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
        /// 509. Fibonacci Number
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Dynamic Programming")]
        [Priority(2)]
        public void TestMethod509()
        {
            int input1 = 3;
            int input2 = 5;

            Question myQ = new Question();
            Console.WriteLine("N = {0}", input1);
            Console.WriteLine("F number is {0}", myQ.Fib(input1));
            Console.WriteLine("N = {0}", input2);
            Console.WriteLine("F number is {0}", myQ.Fib(input2));
        }

        /// <summary>
        /// 643. Maximum Average Subarray I
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Dynamic Programming")]
        [Priority(2)]
        public void TestMethod643()
        {
            int[] input1 = { 1, 12, -5, -6, 50, 3 };
            int input2 = 4;
            
            Question myQ = new Question();
            double result = myQ.FindMaxAverage(input1, input2);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 665. Non-decreasing Array
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod665()
        {
            int[] input = { 4, 5, 3, 7 };

            Question myQ = new Question();
            bool result = myQ.CheckPossibility(input);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 674. Longest Continuous Increasing Subsequence
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod674()
        {
            int[] input = { 1, 3, 5, 8 };

            Question myQ = new Question();
            int result = myQ.FindLengthOfLCIS(input);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 747. Largest Number At Least Twice of Others
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod747()
        {
            int[] input = {0, 0, 3, 2};

            Question myQ = new Question();
            int result = myQ.DominantIndex(input);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 819. Most Common Word
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod819()
        {
            Question myQ = new Question();
            //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string paragraph = "Bob";
            Console.WriteLine(paragraph);
            string[] banned = { "hit" };
            Console.WriteLine(myQ.MostCommonWord(paragraph, banned));
        }

        /// <summary>
        /// 867. Transpose Matrix
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod867()
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
            Question test = new Question();
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
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod905()
        {
            int[] input = { 3, 1, 2, 4, 7, 8 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Question test = new Question();
            int[] output = test.SortArrayByParity(input);
            Console.WriteLine();
            for (int j = 0; j < input.Length; j++)
            {
                Console.Write(output[j] + " ");
            }
        }

        /// <summary>
        /// 917. Reverse Only Letters
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod917()
        {
            string input = "Test1ng-Leet=code-Q!";
            Console.WriteLine(input);
            Question myQ = new Question();
            Console.WriteLine(myQ.ReverseOnlyLetters(input));
            Console.WriteLine(myQ.ReverseOnlyLettersOpt(input));
        }

        /// <summary>
        /// 977. Squares of a Sorted Array
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod977()
        {
            int[] input = { -4, -1, 0, 3, 10 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Question test = new Question();
            int[] output = test.SortedSquares(input);
            Console.WriteLine();
            for (int j = 0; j < input.Length; j++)
            {
                Console.Write(output[j] + " ");
            }
        }

        /// <summary>
        /// 985. Sum of Even Numbers After Queries
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod985()
        {
            int[] input1 = { 1, 2, 3, 4 };
            int[][] input2 = new int[4][];
            input2[0] = new int[] { 1, 0 };
            input2[1] = new int[] { -3, 1 };
            input2[2] = new int[] { -4, 0 };
            input2[3] = new int[] { 2, 3 };

            int[] input3 = { 3 };
            int[][] input4 = new int[1][];
            input4[0] = new int[] { -2, 0};

            for (int i = 0; i < input1.Length; i++)
            {
                Console.Write(input1[i] + " ");
            }
            Question test = new Question();
            int[] output = test.SumEvenAfterQueriesOpt(input1,input2);
            Console.WriteLine();
            for (int j = 0; j < output.Length; j++)
            {
                Console.Write(output[j] + " ");
            }
        }

        /// <summary>
        /// 1013. Partition Array Into Three Parts With Equal Sum
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod1013()
        {
            int[] input = { 3, 3, 6, 5, -2, 2, 5, 1, -9, 4 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
            Question test = new Question();
            bool output = test.CanThreePartsEqualSum(input);
            Console.WriteLine(output);
        }
    }
}
