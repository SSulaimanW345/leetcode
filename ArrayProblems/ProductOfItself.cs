using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ArrayProblems
{   
    // Concept of postix and prefix
    public class ProductOfItself
    {
        public static int[] ProductOfArrayExceptSelfUsingDivision(int[] arr) 
        {
            int totalProduct = arr.Aggregate(1, (acc, x) => acc * x);
            return arr.Select((x) => x/ totalProduct).ToArray();

            // if you donot consider the 0 edge case
        }
        public static int[] ProductOfArrayExceptSelfUsingPostfixAndPrefixArrays(int[] arr)
        {
            int[] postfix = new int[arr.Length];
            int[] prefix = new int[arr.Length];
            prefix[0] = arr[0];
            postfix[arr.Length -1] = arr[arr.Length -1];
            for (int i = 1; i < arr.Length; i++) 
            {
               prefix[i] = prefix[i - 1] * arr[i];
            }
            for (int i = arr.Length -2 ; i >= 0; i--)
            {
                postfix[i] = postfix[i + 1] * arr[i];
            }
            return arr.Select((x, index) =>
            {
                if (index == 0) return postfix[index + 1];
                else if (index == arr.Length - 1) return prefix[index - 1];
                else return postfix[index + 1] * prefix[index - 1];
            }).ToArray();
        }
    }
}
