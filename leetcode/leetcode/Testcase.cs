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
