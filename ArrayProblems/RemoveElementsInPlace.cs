using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ArrayProblems
{
    public class RemoveElementsInPlace
    {
        public static int RemoveElementsEqualToValInplace(int[] arr, int val) 
        {
            int j = 0, k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != val) {arr[k] = arr[i]; k++;}
            }
            return k;
        }
    }
}
