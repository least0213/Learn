using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class Question
    {
        /// <summary>
        /// 70. Climbing Stairs
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }

            int f1 = 1;
            int f2 = 2;
            int f3 = 0;
            int i = 3;
            while (i++ <= n)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }

            return f3;
        }

        /// <summary>
        /// 121. Best Time to Buy and Sell Stock
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            for (int i = prices.Length - 1; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    int temp = prices[i] - prices[j];
                    if (temp > 0)
                    {
                        if (temp > max)
                        {
                            max = temp;
                        }
                    }
                }
            }
            return max;
        }

        public int MaxProfitOpt(int[] prices)
        {
            int maxValue = 0;
            if (prices.Length == 0)
            {
                return maxValue;
            }

            int minPrice = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > minPrice)
                {
                    if (prices[i] - minPrice > maxValue)
                    {
                        maxValue = prices[i] - minPrice;
                    }
                }
                else
                {
                    minPrice = prices[i];
                }
            }

            return maxValue;
        }

        /// <summary>
        /// 268. Missing Number
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MissingNumber(int[] nums)
        {
            int sum_nums = nums.Sum();
            //for (int i=0; i<nums.Length; i++)
            //{
            //    sum_nums += nums[i];
            //}
            int n = nums.Length;
            int sum_full = n * (n + 1) / 2;
            int result = sum_full - sum_nums;
            return result;
        }

        /// <summary>
        /// 387. First Unique Character in a String
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FirstUniqChar(string s)
        {
            if (s.Length == 0)
            {
                return -1;
            }
            if (s.Length == 1)
            {
                return 0;
            }
            Dictionary<char, int> fuc = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!fuc.Keys.Contains(s[i]))
                {
                    fuc.Add(s[i], i);
                }
                else
                {
                    char index = s[i];
                    fuc[index] = -1;
                }
            }
            if (!fuc.Values.Contains(-1))
            {
                return 0;
            }
            if (fuc.Values.Count() == -fuc.Values.Sum())
            {
                return -1;
            }
            int min = -2;
            foreach (int index in fuc.Values)
            {
                if (index == -1)
                {
                    continue;
                }
                if (min == -2)
                {
                    min = index;
                    continue;
                }
                if (index < min)
                {
                    min = index;
                }
            }
            return min;
        }

        /// <summary>
        /// 443. String Compression
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public int Compress(char[] chars)
        {
            if (chars.Length <= 1)
            {
                return chars.Length;
            }
            List<char> result = new List<char>();
            int start = 0;
            int end = 0;
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[start])
                {
                    end = i;
                    if (i == chars.Length - 1)
                    {
                        if (end == start)
                        {
                            result.Add(chars[start]);
                        }
                        if (end > start)
                        {
                            result.Add(chars[start]);
                            string temp = (end - start + 1).ToString();
                            for (int j = 0; j < temp.Length; j++)
                            {
                                result.Add(temp[j]);
                            }
                        }
                    }
                }
                else
                {
                    if (end == start)
                    {
                        result.Add(chars[start]);
                    }
                    if (end > start)
                    {
                        result.Add(chars[start]);
                        string temp = (end - start + 1).ToString();
                        for (int j = 0; j < temp.Length; j++)
                        {
                            result.Add(temp[j]);
                        }
                    }
                    start = i;
                    end = start;
                }
            }
            return result.Count;
        }

        /// <summary>
        /// 448. Find All Numbers Disappeared in an Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();
            Dictionary<int, int> process = new Dictionary<int, int>();
            int n = nums.Length;
            for (int i = 1; i <= n; i++)
            {
                process.Add(i, 0);
            }
            for (int i = 0; i < n; i++)
            {
                if (process.Keys.Contains(nums[i]))
                {
                    int index = nums[i];
                    process[index]++;
                }
            }
            foreach (KeyValuePair<int, int> num in process)
            {
                if (num.Value == 0)
                {
                    result.Add(num.Key);
                }
            }
            return result;
        }

        /// <summary>
        /// 819. Most Common Word
        /// "Bob hit a ball, the hit BALL flew far after it was hit.";
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string MostCommonWord(string paragraph, string[] banned)
        {
            for (int i = 0; i < paragraph.Length; i++)
            {
                if (Char.IsPunctuation(paragraph[i]))
                {
                    paragraph = paragraph.Remove(i, 1);
                }
            }

            Dictionary<string, int> map = new Dictionary<string, int>();
            int start = 0;
            int end = 0;
            for (int i = 0; i < paragraph.Length; i++)
            {
                if (paragraph[i] == ' ' || i == paragraph.Length - 1)
                {
                    if (i == paragraph.Length - 1)
                    {
                        end = i;
                    }
                    if (end >= start)
                    {
                        string word = paragraph.Substring(start, end - start + 1).ToLower();
                        if (!banned.Contains(word))
                        {
                            if (!map.ContainsKey(word))
                            {
                                map.Add(word, 0);
                            }
                            else
                            {
                                map[word]++;
                            }
                        }
                    }
                    if ((i + 1) < paragraph.Length)
                    {
                        start = i + 1;
                        end = i + 1;
                    }
                }
                else
                {
                    end = i;
                }
            }

            int max = 0;
            foreach (int value in map.Values)
            {
                if (value > max)
                {
                    max = value;
                }
            }

            string most = null;
            foreach (KeyValuePair<string, int> temp in map)
            {
                if (temp.Value == max)
                {
                    most = temp.Key;
                    break;
                }
            }
            return most;
        }

        /// <summary>
        /// 867. Transpose Matrix
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[][] Transpose(int[][] A)
        {
            int col = A.Length;
            int row = A[0].Length;
            int[][] output = new int[row][];

            for (int i = 0; i < row; i++)
            {
                output[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    output[i][j] = A[j][i];
                }
            }
            return output;
        }

        /// <summary>
        /// 905. Sort Array By Parity
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] SortArrayByParity(int[] A)
        {
            if (A.Length <= 1)
            {
                return A;
            }

            int l = 0;
            int r = A.Length - 1;
            int temp = 0;
            while (l < r)
            {
                if (A[l] % 2 == 1 && A[r] % 2 == 0)
                {
                    temp = A[l];
                    A[l] = A[r];
                    A[r] = temp;
                    l++;
                    r--;
                }

                if (A[l] % 2 == 0)
                {
                    l++;
                }

                if (A[r] % 2 == 1)
                {
                    r--;
                }
            }

            return A;
        }

        /// <summary>
        /// 977. Squares of a Sorted Array
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] SortedSquares(int[] A)
        {
            if (A.Length == 0)
            {
                return A;
            }
            if (A.Length == 1)
            {
                A[0] = A[0] * A[0];
                return A;
            }
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * A[i];
            }
            int max;

            for (int m = 0; m < A.Length - 1; m++)
            {
                for (int n = 0; n < A.Length - 1; n++)
                {
                    if (A[n] > A[n + 1])
                    {
                        max = A[n];
                        A[n] = A[n + 1];
                        A[n + 1] = max;
                    }
                }
            }
            return A;
        }

    }
}
