using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ArrayProblems
{
    public class GroupAnagrams
    {
        public static List<IList<string>> GroupAnagramsUsingDict(string[] strs) 
        {
            var resultList = new List<List<string>>();
            Dictionary<string, List<string>> strList = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                string sortedStr = new string(charArray);

                if (!strList.ContainsKey(sortedStr))
                {
                    strList[sortedStr] = new List<string>();
                }
                strList[sortedStr].Add(str);
            }

            return new List<IList<string>>(strList.Values);
        } 
    }
}
