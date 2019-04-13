using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class Question
    {
        /// <summary>
        /// 20. Valid Parentheses
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> parentheses = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (parentheses.Count == 0)
                {
                    parentheses.Push(s[i]);
                }
                else
                {
                    if (IsMatch(parentheses.Peek(), s[i]))
                    {
                        parentheses.Pop();
                    }
                    else
                    {
                        parentheses.Push(s[i]);
                    }
                }
            }

            if (parentheses.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsMatch(char a, char b)
        {
            switch (a)
            {
                case '(':
                    if (b == ')')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '{':
                    if (b == '}')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '[':
                    if (b == ']')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }

        /// <summary>
        /// 53. Maximum Subarray
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int sum = 0;
            int max = nums[0];
            for (int i = 0; i<nums.Length; i++)
            {
                if (sum > 0)
                {
                    sum += nums[i];
                }
                else
                {
                    sum = nums[i];
                }
                if(sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }

        /// <summary>
        /// 66. Plus One
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            int a = 1;
            List<int> temp = new List<int>();

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int current = (digits[i] + a) % 10;
                a = (digits[i] + a) / 10;
                temp.Add(current);
            }

            if (a != 0)
            {
                temp.Add(a);
            }

            int length = temp.Count;
            int[] result = new int[length];

            for (int j = 0; j < length; j++)
            {
                result[j] = temp[length - 1 - j];
            }

            return result;
        }

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
        /// 125. Valid Palindrome
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s)
        {
            if (s.Length < 2)
            {
                return true;
            }

            StringBuilder temp = new StringBuilder();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    temp.Append(Char.ToLower(s[i]));
                }
                if (Char.IsDigit(s[i]))
                {
                    temp.Append(s[i]);
                }
            }

            string letter = temp.ToString();

            int start = 0;
            int end = letter.Length - 1;
            while (start < letter.Length/2)
            {
                if (letter[start] == letter[end])
                {
                    start++;
                    end--;
                    continue;
                }
                else
                {
                    return false;
                }               
            }

            return true;
        }

        public bool IsPalindromeOpt(string s)
        {
            if (s.Length < 2)
            {
                return true;
            }
            
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                if (Char.IsLetterOrDigit(s[start]))
                {
                    if (Char.IsLetterOrDigit(s[end]))
                    {
                        if (Char.ToLower(s[start]) == Char.ToLower(s[end]))
                        {
                            start++;
                            end--;
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        end--;
                    }
                }
                else
                {
                    start++;
                }
            }

            return true;
        }

        /// <summary>
        /// 238. Product of Array Except Self
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }

            int[] result = new int[nums.Length];
            result[0] = 1;
            int left = 1;
            int right = 1;
            for (int i = 1; i<nums.Length;i++)
            {
                left *= nums[i-1];
                result[i] = left;
            }
            for (int j = nums.Length - 2; j >= 0; j--)
            {
                right *= nums[j+1];
                result[j] *= right;  
            }
            return result;
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
        /// 345. Reverse Vowels of a String
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseVowels(string s)
        {
            if (s.Length < 2)
            {
                return s;
            }

            StringBuilder result = new StringBuilder(s);
            int startIndex = 0;
            int endIndex = s.Length - 1;
            string vowels = "aeiouAEIOU";

            while (startIndex < s.Length && endIndex >= 0)
            {
                if (!vowels.Contains(s[endIndex]))
                {
                    endIndex--;
                    continue;
                }
                if (!vowels.Contains(s[startIndex]))
                {
                    startIndex++;
                    continue;
                }
                result[startIndex] = s[endIndex];
                startIndex++;
                endIndex--;
            }
            return result.ToString();
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
        /// 509. Fibonacci Number
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int Fib(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            if (N == 1)
            {
                return 1;
            }

            int f0 = 0;
            int f1 = 1;
            int f2 = 0;
            int i = 2;
            while (i++ <= N)
            {
                f2 = f0 + f1;
                f0 = f1;
                f1 = f2;
            }

            return f2;
        }

        /// <summary>
        /// 643. Maximum Average Subarray I
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public double FindMaxAverage(int[] nums, int k)
        {
            double sum = 0;
            double max = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            max = sum;

            int start = 0;
            int end = k;
            for (; end < nums.Length; end++)
            {
                sum -= nums[start];
                sum += nums[end];
                start++;
                if (sum > max)
                {
                    max = sum;
                }
            }

            return max / k;
        }

        /// <summary>
        /// 665. Non-decreasing Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool CheckPossibility(int[] nums)
        {
            if (nums.Length < 2)
            {
                return true;
            }

            int count = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    if (count > 1)
                    {
                        return false;
                    }
                    if (i - 1 < 0 || nums[i - 1] < nums[i + 1])
                    {
                        nums[i] = nums[i + 1];
                    }
                    else
                    {
                        nums[i + 1] = nums[i];
                    }
                    count++;
                }
            }

            if (count <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 674. Longest Continuous Increasing Subsequence
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            int count = 1;
            int max = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                    }
                    count = 1;
                }
            }
            if (count > max)
            {
                max = count;
            }
            return max;
        }

        /// <summary>
        /// 747. Largest Number At Least Twice of Others
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int DominantIndex(int[] nums)
        {
            if (nums.Length < 2)
            {
                return 0;
            }
            int maxF = 0;
            int maxS = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxF)
                {
                    maxS = maxF;
                    maxF = nums[i];
                    index = i;
                }
                else if (nums[i] > maxS)
                {
                    maxS = nums[i];
                }
            }
            if (maxF < maxS * 2)
            {
                return -1;
            }

            return index;
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
        /// 917. Reverse Only Letters
        /// a-bC-dEf-ghIj
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public string ReverseOnlyLetters(string S)
        {
            if (S.Length < 2)
            {
                return S;
            }

            StringBuilder result = new StringBuilder();
            char[] input = S.ToCharArray();

            int index = S.Length - 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    while (index >= 0)
                    {
                        if (Char.IsLetter(input[index]))
                        {
                            result.Append(input[index]);
                            index--;
                            break;
                        }
                        else
                        {
                            index--;
                        }
                    }

                }
                else
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }

        public string ReverseOnlyLettersOpt(string S)
        {
            if (S.Length < 2)
            {
                return S;
            }

            StringBuilder result = new StringBuilder(S);
            int startIndex = 0;
            int endIndex = S.Length - 1;

            while (startIndex < S.Length && endIndex >= 0)
            {
                if (!Char.IsLetter(Convert.ToChar(S[endIndex])))
                {
                    endIndex--;
                    continue;
                }
                if (!Char.IsLetter(Convert.ToChar(S[startIndex])))
                {
                    startIndex++;
                    continue;
                }
                result[startIndex] = S[endIndex];
                startIndex++;
                endIndex--;
            }
            return result.ToString();
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

        /// <summary>
        /// 985. Sum of Even Numbers After Queries
        /// </summary>
        /// <param name="A"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            int resultLengh = queries.Length;
            int[] result = new int[resultLengh];

            for (int i = 0; i < queries.Length; i++)
            {
                int value = queries[i][0];
                int index = queries[i][1];
                A[index] += value;
                int sum = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] % 2 == 0)
                    {
                        sum += A[j];
                    }
                }
                result[i] = sum;
            }

            return result;
        }

        public int[] SumEvenAfterQueriesOpt(int[] A, int[][] queries)
        {
            int S = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                    S += A[i];
            }

            int[] ans = new int[queries.Length];

            for (int i = 0; i < queries.Length; ++i)
            {
                int val = queries[i][0], index = queries[i][1];
                if (A[index] % 2 == 0)
                { S -= A[index]; }
                A[index] += val;
                if (A[index] % 2 == 0)
                { S += A[index]; }
                ans[i] = S;
            }

            return ans;
        }

        /// <summary>
        /// 1013. Partition Array Into Three Parts With Equal Sum
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public bool CanThreePartsEqualSum(int[] A)
        {
            bool result = false;
            int sum = 0;
            
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            if (sum%3 != 0)
            {
                return false;
            }

            int target = sum / 3;
            int count = 0;
            int tempSum = 0;

            for (int j = 0; j < A.Length; j++)
            {
                tempSum += A[j];
                if (tempSum == target)
                {
                    tempSum = 0;
                    count++;
                    if (count == 2)
                    {
                        return true;
                    }
                }
            }
            return result;
        }

    }

    /// <summary>
    /// 303. Range Sum Query - Immutable
    /// </summary>
    public class NumArray
    {
        private int[] sum;

        public NumArray(int[] nums)
        {
            sum = new int[nums.Length];
            for (int i = 0; i<nums.Length; i++)
            {
                if (i == 0)
                {
                    sum[i] = nums[i];
                }
                else
                {
                    sum[i] = sum[i - 1] + nums[i];
                }
            }

        }

        public int SumRange(int i, int j)
        {
            if (i == 0)
            {
                return sum[j];
            }
            else
            {
                return sum[j] - sum[i - 1];
            }
        }
    }

}
