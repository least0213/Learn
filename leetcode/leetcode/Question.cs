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
    }
}
