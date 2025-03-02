using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ArrayProblems
{
    public class TopKFrequentElements
    {   
        // O(nlogk)
        public static int[] TopKFrequentElementsUsingHeap(int[] arr, int k) 
        {
            int[] outputArr = new int[k];
            Dictionary<int, int> freqDict = new Dictionary<int, int>();
            PriorityQueue<int, int> pQfreq = new PriorityQueue<int, int>();
            foreach (int num in arr)
            {
                freqDict[num] = freqDict.GetValueOrDefault(num, 0) + 1;
            }
            foreach (KeyValuePair<int, int> item in freqDict)
            {
                pQfreq.Enqueue(item.Key, -item.Value);
            }
            for (int j = 0; j < k; j++)
            {
                outputArr[j] = pQfreq.Dequeue();
            }
            return outputArr;
        }
        // bucket or implementations
    }
}
