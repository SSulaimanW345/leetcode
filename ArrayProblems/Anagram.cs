using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ArrayProblems
{
    public class Anagram
    {
        public static bool CheckStringsAnagramUseDicts(string a, string b) 
        {
            if (a.Length != b.Length) return false;
            Dictionary<char, int> charCountA = new Dictionary<char, int>();
            Dictionary<char, int> charCountB = new Dictionary<char, int>();
            foreach (char c in a) { if (charCountA.ContainsKey(c)) charCountA[c] += 1; else charCountA[c] = 1; }
            foreach (char c in b) { if (charCountB.ContainsKey(c)) charCountB[c] += 1; else charCountB[c] = 1; }
            foreach (char c in charCountA.Keys) { if (!charCountB.ContainsKey(c) || charCountB[c] != charCountA[c])return false; }
            return true;
        }
        public static bool CheckAnagramUseSorting(string a, string b) 
        {
            if (a.Length != b.Length) return false;
            char[] arrA = a.ToCharArray();
            char[] arrB = b.ToCharArray();

            Array.Sort(arrA);
            Array.Sort(arrB);
            return new string(arrA) == new string(arrB);
        }
        // O(N) time O(1) space 26 chars only
        public static bool CheckStringsAnagramUsingDictTwo(string a, string b) 
        {
            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            if (a.Length != b.Length) return false;
            for(int i = 0; i < a.Length; i++) 
            {
                if (!charsCount.ContainsKey(a[i])) charsCount[a[i]]=0;
                if (!charsCount.ContainsKey(b[i])) charsCount[b[i]] = 0;
                charsCount[a[i]]++; 
                charsCount[b[i]]--;
            }

            foreach (int value in charsCount.Values) 
            {
                if(value != 0) return false;
            }
            return true;
        }
    }
}
