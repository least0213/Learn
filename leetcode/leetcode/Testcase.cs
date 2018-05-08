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
    }
}
