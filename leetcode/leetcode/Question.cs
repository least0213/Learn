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
        /// 819. Most Common Word
        /// "Bob hit a ball, the hit BALL flew far after it was hit.";
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string MostCommonWord(string paragraph, string[] banned)
        {
            for (int i= 0; i< paragraph.Length; i++)
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
                    if (end>=start)
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
                    if ((i + 1)< paragraph.Length)
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
                if (value>max)
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
