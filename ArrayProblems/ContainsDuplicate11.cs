using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ArrayProblems
{
    public class ContainsDuplicate11
    {
        public static bool ContainsDuplicate11UseDict(int[] arr, int k) 
        {   
            Dictionary<int,int> numsDict = new Dictionary<int,int>();
            for (int i=0;i< arr.Length;i++)
            {
                if (numsDict.ContainsKey(arr[i])) 
                {
                    if (Math.Abs(numsDict[arr[i]] - i) <= k) return true;
                    numsDict[arr[i]] = i;
                }
                else numsDict[arr[i]] = i;
            }
            return false;
        }
    }
}
