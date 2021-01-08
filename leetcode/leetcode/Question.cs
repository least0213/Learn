using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace leetcode
{
    public class Question
    {
        /// <summary>
        /// 3. Longest Substring Without Repeating Characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 2)
            {
                return s.Length;
            }

            int max = 0;
            char current = s[0];
            int count = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (current != s[i])
                {
                    count++;
                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                        count = 1;
                    }
                }
            }
            if (count > max)
            {
                max = count;
            }
            return max;
        }

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
        /// 38. Count and Say
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string CountAndSay(int n)
        {
            if (n == 0)
            {
                return "";
            }
            if (n == 1)
            {
                return "1";
            }

            string s = CountAndSay(n - 1);
            StringBuilder result = new StringBuilder();
            char current = s[0];
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == current)
                {
                    count++;
                }
                else
                {
                    result.Append(count);
                    result.Append(current);
                    current = s[i];
                    count = 1;
                }
            }
            result.Append(count);
            result.Append(current);
            return result.ToString();
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
        /// 344. Reverse String
        /// </summary>
        /// <param name="s"></param>
        public void ReverseString(char[] s)
        {
            int start = 0;
            int end = s.Length - 1;
            char temp;
            while (start < end)
            {
                temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
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
        /// 383. Ransom Note
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
            {
                return false;
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (!magazine.Contains(ransomNote[i]))
                {
                    return false;
                }
                else
                {
                    int index = magazine.IndexOf(ransomNote[i]);
                    magazine = magazine.Remove(index, 1);
                }
            }

            return true;
        }

        public bool CanConstructOpt(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
            {
                return false;
            }

            int[] temp = new int[26];
            int index = 0;
            for (int i = 0; i< magazine.Length; i++)
            {
                index = magazine[i] - 'a';
                temp[index]++;
            }
            for (int j = 0; j < ransomNote.Length; j++)
            {
                index = ransomNote[j] - 'a';
                temp[index]--;
                if (temp[index] < 0)
                {
                    return false;
                }
            }

            return true;
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
            StringBuilder result = new StringBuilder();
            char current = chars[0];
            int currentCount = 1;
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == current)
                {
                    currentCount++;
                    if (i == chars.Length-1)
                    {
                        result.Append(chars[i]);
                        if (currentCount > 1)
                        {
                            result.Append(currentCount.ToString());
                        }
                    }
                }
                else
                {
                    result.Append(current);
                    if (currentCount > 1)
                    {
                        result.Append(currentCount.ToString());
                    }
                    current = chars[i];
                    currentCount = 1;
                }
            }
            return result.Length;
        }

        public int CompressOpt(char[] chars)
        {
            if (chars.Length <= 1)
            {
                return chars.Length;
            }
 
            char current = chars[0];
            int currentCount = 0;
            int end = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == current)
                {
                    currentCount++;
                    if (i == chars.Length - 1)
                    {
                        chars[end] = current;
                        if (currentCount > 1)
                        {
                            string temp = currentCount.ToString();
                            for (int j = 0; j < temp.Length; j++)
                            {
                                chars[end + 1 + j] = temp[j];
                            }
                            end = end + 1 + temp.Length;
                        }
                        else
                        {
                            end += 1;
                        }
                    }
                }
                else
                {
                    chars[end] = current;
                    if (currentCount > 1)
                    {
                        string temp = currentCount.ToString();
                        for (int j = 0; j < temp.Length; j++)
                        {
                            chars[end + 1 + j] = temp[j];
                        }
                        end = end + 1 + temp.Length;
                    }
                    else
                    {
                        end += 1;
                    }
                    current = chars[i];
                    currentCount = 1;
                    if (i == chars.Length - 1)
                    {
                        chars[end] = current;
                        end += 1;
                    }
                }
            }

            return end;
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
        /// 485. Max Consecutive Ones
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int temp = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    temp += nums[i];
                }
                else
                {
                    if (temp > max)
                    {
                        max = temp;                      
                    }
                    temp = 0;
                }
            }
            if (temp > max)
            {
                max = temp;
            }
            return max;
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
        /// 520. Detect Capital
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool DetectCapitalUse(string word)
        {
            if (word.Length < 2)
            {
                return true;
            }

            if (Char.IsUpper(word[0]))
            {
                if (Char.IsUpper(word[1]))
                {
                    for (int i = 2; i < word.Length; i++)
                    {
                        if (Char.IsLower(word[i]))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = 2; i < word.Length; i++)
                    {
                        if (Char.IsUpper(word[i]))
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i<word.Length; i++)
                {
                    if (Char.IsUpper(word[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 551. Student Attendance Record I
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool CheckRecord(string s)
        {
            int countA = 0;
            int countL = 0;
            bool coutinueL = false;

            for (int i = 0; i < s.Length; i++)
            {               
                if (s[i] == 'A')
                {
                    if (countA > 1)
                    {
                        return false;
                    }
                    countA++;
                }

                if (s[i] == 'L')
                {
                    if (countL > 2)
                    {
                        return false;
                    }
                    countL++;
                    coutinueL = true;
                }
                if (s[i] != 'L' && countL <=2)
                {
                    countL = 0;
                    coutinueL = false;
                }
            }
            if (countA > 1 || countL > 2)
            {
                return false;
            }
            return true;
        }

        public bool CheckRecordOpt(string s)
        {
            if (s.Contains("LLL"))
            {
                return false;
            }

            int numA = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    numA++;
                }
                if (numA > 1)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckRecordOptRex(string s)
        {
            if (Regex.IsMatch(s, ".*A.*A.*") || Regex.IsMatch(s, ".*LLL.*"))
            {
                return false;
            }
            return true;
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
        /// 680. Valid Palindrome II
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool ValidPalindrome(string s)
        {
            if (s.Length < 2)
            {
                return true;
            }
                   
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return IsValidPalindrome(s, start, end - 1) || IsValidPalindrome(s, start+1, end);
                }
                start++;
                end--;
            }

            return true;
        }

        public static bool IsValidPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
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
        /// 929. Unique Email Addresses
        /// </summary>
        /// <param name="emails"></param>
        /// <returns></returns>
        public int NumUniqueEmails(string[] emails)
        {
            if (emails.Length < 2)
            {
                return emails.Length;
            }

            List<string> result = new List<string>();
            foreach (string email in emails)
            {
                string temp = ValidEmail(email);
                if (!result.Contains(temp))
                {
                    result.Add(temp);
                }
            }

            return result.Count;
        }

        public static string ValidEmail(string email)
        {
            int index = email.IndexOf('@');
            string local = email.Substring(0, index);
            string domain = email.Substring(index, email.Length - index);
            if (local.Contains("."))
            {
                local = local.Replace(".", "");
            }
            if (local.Contains("+"))
            {
                int indexPlus = local.IndexOf('+');
                local = local.Substring(0, indexPlus);
            }
            return local + domain;
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

        /// <summary>
        /// 1374. Generate a String With Characters That Have Odd Counts
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string GenerateTheString(int n)
        {
            Random rnd = new Random();
            char radmonChar = (char)rnd.Next('a', 'z');

            if (n % 2 != 0)
            {
                return new string(radmonChar, n);
            }

            return new string(radmonChar, n - 1) + ((char)(radmonChar + 1)).ToString();
        }

        /// <summary>
        /// 1374. Generate a String With Characters That Have Odd Counts
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string GenerateTheString2(int n)
        {
            if (n % 2 != 0)
            {
                return new string('a', n);
            }

            return new string('a', n - 1) + "b";
        }

        /// <summary>
        /// 1446. Consecutive Characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MaxPower(string s)
        {
            if (s.Length < 2)
            {
                return 1;
            }

            int maxPower = 1;
            int power = 1;
            
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    power++;
                }
                else
                {
                    maxPower = Math.Max(maxPower, power);
                    power = 1;
                }
            }
            maxPower = Math.Max(maxPower, power);

            return maxPower;
        }

        /// <summary>
        /// 1662. Check If Two String Arrays are Equivalent
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            bool result = false;
            string string1 = null;
            string string2 = null;
            for (int i = 0; i < word1.Length; i++)
            {
                string1 += word1[i];
            }
            for (int j = 0; j < word2.Length; j++)
            {
                string2 += word2[j];
            }
            if (string1 == string2)
            {
                result = true;
                return result;
            }
            return result;
        }

        /// <summary>
        /// 1662. Check If Two String Arrays are Equivalent
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public bool ArrayStringsAreEqual2(string[] word1, string[] word2)
        {
            return String.Join("", word1).Equals(String.Join("", word2));
        }

        /// <summary>
        /// 1678. Goal Parser Interpretation
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public string Interpret(string command)
        {
            if (command.Contains("()"))
            {
                command = command.Replace("()", "o");
            }
            if (command.Contains("(al)"))
            {
                command = command.Replace("(al)", "al");
            }
            return command;
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
