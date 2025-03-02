using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ArrayProblems
{
    public class TwoSum
    {
        public static int[] TwoSumUsingHashMap(int[] arr, int target) 
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            for (int i=0;i< arr.Length;i++ ) 
            {
                int complement = target - arr[i];
                if (dict.ContainsKey(complement)) 
                {
                    return [dict[complement], i];
                }
                dict[arr[i]] = i;
            }

            return Array.Empty<int>();
        }

        public static int[] TwoSumBruteForce(int[] arr, int target) 
        {
            for (int i = 0; i < arr.Length; i++) 
            {   
                int complement = target - arr[i];
                for (int j=i+1; j<arr.Length; j++) 
                {
                    if (complement == arr[j]) return [i, j];
                }
            }
            return Array.Empty<int>();
        }
    }
}
