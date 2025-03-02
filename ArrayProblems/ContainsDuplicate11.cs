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

        public static bool ContainsDuplicate11UseSlidingWindow(int[] arr, int k) 
        {
            HashSet<int> window = new HashSet<int>();
            for (int i=0;i< arr.Length;i++) 
            {
                if (window.Contains(arr[i])) return true;
                window.Add(arr[i]);
                if (window.Count > k ) window.Remove(arr[i - k]);
            }
            return false;
        }
    }
}
