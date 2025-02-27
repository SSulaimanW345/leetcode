using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ArrayProblems
{
    public class ContainsDuplicate
    {
        // O(N) Space // O(N) time
        public static bool ContainsDuplicateUseSet(int[] arr)
        {
            HashSet<int> numberSet = new HashSet<int>(); 
            foreach (int num in arr) 
            {
                if (numberSet.Contains(num)) return true;
                numberSet.Add(num);
            }
            return false;
        }
        //O(n log n) Time, O(1) Space
        public static bool ContainsDuplicateUseSorting(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i]) return true;
            }
            return false;
        }
        //O(n) Time, O(n) Space
        public static bool ContainsDuplicateUseDictionary(int[] arr)
        {
            Dictionary<int, bool> numDict = new Dictionary<int, bool>();
            foreach (int num in arr)
            {
                if (numDict.ContainsKey(num)) return true; numDict.Add(num, true);
            }
            return false;
        }

    }
}
