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
        /// 3. Longest Substring Without Repeating Characters
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod3()
        {
            string input1 = "abcabcbb";
            string input2 = "pwwkew";
            int expected = 3;

            Question test = new Question();
            int actual = test.LengthOfLongestSubstring(input1);
            Console.Write(actual);

            Assert.AreEqual(expected, actual);
        }

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
        /// 38. Count and Say
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod38()
        {
            int input = 5;
            string expected = "111221";

            Question test = new Question();
            string actual = test.CountAndSay(input);
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
            int[] input1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4, 7 };
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
            int[] expected = { 1, 0, 0 };
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
            int expected = 1;

            NumArray test = new NumArray(input);
            //int[] sumList = test.NumArray(input);
            int actual = test.SumRange(0, 2);

            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 344. Reverse String
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod344()
        {
            char[] input = { 'h', 'e', 'l', 'l', 'o' };
            char[] expected = { 'o', 'l', 'l', 'e', 'h' };

            Question myQ = new Question();
            myQ.ReverseString(input);
            char[] actual = input;

            CollectionAssert.AreEqual(expected, actual);
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

            string expected = "leotcede";
            Console.WriteLine("expect output string is : leotcede");

            Question myQ = new Question();
            string actual = myQ.ReverseVowels(input);
            Console.WriteLine("actual output string is : {0}", actual);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 383. Ransom Note
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod383()
        {
            string input1 = "leeee";
            string input2 = "leetcode";
            Console.WriteLine("input1 string is : {0} \ninput2 string is : {1}", input1, input2);
            bool expected = false;

            Question myQ = new Question();
            bool actual = myQ.CanConstructOpt(input1, input2);
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
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
            string s1 = "leetcode";
            Console.WriteLine(s1);
            string s2 = "loveleetcode";
            Console.WriteLine(s2);
            int expected1 = 0;
            int expected2 = 2;

            Question myQ = new Question();
            int actual1 = myQ.FirstUniqChar(s1);
            Console.WriteLine(actual1);
            int actual2 = myQ.FirstUniqChar(s2);
            Console.WriteLine(actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
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

            char[] input1 = new char[] { 'a', 'a', 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            char[] input = new char[] { 'a', 'b', 'c' };
            char[] input3 = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            int expected = 3;

            Question myQ = new Question();
            int actual = myQ.CompressOpt(input);
            Console.WriteLine("\n" + actual);

            Assert.AreEqual(expected, actual);
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
        /// 485. Max Consecutive Ones
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod485()
        {
            int[] input = { 1, 1, 0, 1, 1, 1 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine("\n");
            int expected = 3;

            Question myQ = new Question();
            int actual = myQ.FindMaxConsecutiveOnes(input);

            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
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
            Console.WriteLine("N = {0}", input1);
            int input2 = 5;
            Console.WriteLine("N = {0}", input2);
            int expected1 = 2;
            int expected2 = 5;

            Question myQ = new Question();
            int actual1 = myQ.Fib(input1);
            Console.WriteLine("F number is {0}", actual1);
            int actual2 = myQ.Fib(input2);
            Console.WriteLine("F number is {0}", actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        /// <summary>
        /// 520. Detect Capital
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod520()
        {
            string input1 = "USA";
            Console.WriteLine(input1);
            string input2 = "FlaG";
            Console.WriteLine(input2);
            bool expected1 = true;
            bool expected2 = false;

            Question myQ = new Question();
            bool actual1 = myQ.DetectCapitalUse(input1);
            Console.WriteLine(actual1);
            bool actual2 = myQ.DetectCapitalUse(input2);
            Console.WriteLine(actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        /// <summary>
        /// 551. Student Attendance Record I
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod551()
        {
            string input1 = "APPALLP";
            Console.WriteLine(input1);
            string input2 = "PPALLL";
            Console.WriteLine(input2);
            bool expected1 = false;
            bool expected2 = false;

            Question myQ = new Question();
            bool actual1 = myQ.CheckRecordOptRex(input1);
            Console.WriteLine(actual1);
            bool actual2 = myQ.CheckRecordOptRex(input2);
            Console.WriteLine(actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
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
            double expected = 12.75;

            Question myQ = new Question();
            double actual = myQ.FindMaxAverage(input1, input2);
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
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
            bool expected = true;

            Question myQ = new Question();
            bool actual = myQ.CheckPossibility(input);
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
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
            int expected = 4;

            Question myQ = new Question();
            int actual = myQ.FindLengthOfLCIS(input);
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 680. Valid Palindrome II
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("Array")]
        [Priority(2)]
        public void TestMethod680()
        {
            string input1 = "ebcbbececabbacecbbcbe";
            string input2 = "abcdedca";
            string input3 = "aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga";
            //string input3 = "aguokepatgbnvfqmgmlucupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuclmgmqfvnbgtapekouga";
            bool expected = true;

            Question myQ = new Question();
            bool actual = myQ.ValidPalindrome(input3);
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
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
            int[] input = { 0, 0, 3, 2 };
            int expected = -1;

            Question myQ = new Question();
            int actual = myQ.DominantIndex(input);
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
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
            //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string paragraph = "Bob";
            Console.WriteLine(paragraph);
            string[] banned = { "hit" };
            string expected = "bob";

            Question myQ = new Question();
            string actual = myQ.MostCommonWord(paragraph, banned);
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
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
            int[] expected = { 8, 4, 2, 1, 7, 3 };

            Question test = new Question();
            int[] actual = test.SortArrayByParity(input);
            Console.WriteLine();
            for (int j = 0; j < input.Length; j++)
            {
                Console.Write(actual[j] + " ");
            }

            CollectionAssert.AreEqual(expected, actual);
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
            string expected = "Qedo1ct-eeLg=ntse-T!";

            Question myQ = new Question();
            string actual = myQ.ReverseOnlyLettersOpt(input);
            Console.WriteLine(myQ.ReverseOnlyLetters(input));
            Console.WriteLine(myQ.ReverseOnlyLettersOpt(input));

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 929. Unique Email Addresses
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod929()
        {
            string[] input = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            int expected = 2;

            Question myQ = new Question();
            int actual = myQ.NumUniqueEmails(input);
            Console.WriteLine(myQ.NumUniqueEmails(input));

            Assert.AreEqual(expected, actual);
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
            int[] expected = { 0, 1, 9, 16, 100 };

            Question test = new Question();
            int[] actual = test.SortedSquares(input);
            Console.WriteLine();
            for (int j = 0; j < input.Length; j++)
            {
                Console.Write(actual[j] + " ");
            }

            CollectionAssert.AreEqual(expected, actual);
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
            input4[0] = new int[] { -2, 0 };

            for (int i = 0; i < input1.Length; i++)
            {
                Console.Write(input1[i] + " ");
            }
            int[] expected = { 8, 6, 2, 4 };


            Question test = new Question();
            int[] actual = test.SumEvenAfterQueriesOpt(input1, input2);
            Console.WriteLine();
            for (int j = 0; j < actual.Length; j++)
            {
                Console.Write(actual[j] + " ");
            }

            CollectionAssert.AreEqual(expected, actual);
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
            bool expected = true;
            Console.WriteLine();

            Question test = new Question();
            bool actual = test.CanThreePartsEqualSum(input);
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 1662. Check If Two String Arrays are Equivalent
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod1662()
        {
            string[] word1 = { "a", "cd" };
            string[] word2 = { "ab", "c" };
            Question test = new Question();
            bool expected = true;
            bool actual = test.ArrayStringsAreEqual2(word1, word2);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 1678. Goal Parser Interpretation
        /// </summary>
        [TestMethod]
        [Owner("Steven Ma")]
        [TestCategory("String")]
        [Priority(2)]
        public void TestMethod1678()
        {
            string input = "(al)G(al)()()G";
            Console.WriteLine("input string: {0}", input);

            Question test = new Question();
            string actual = test.Interpret(input);
            string expected = "alGalooG";
            Console.WriteLine("output string: {0}", actual);
            Console.WriteLine("expected string: {0}", expected);

            Assert.AreEqual(expected, actual);
        }
    }
}
