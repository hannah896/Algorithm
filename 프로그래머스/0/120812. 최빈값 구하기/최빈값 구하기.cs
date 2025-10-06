using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[] array) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> list = new List<int>();
        int maxValue = int.MinValue;
        int answer = 0;
        
        foreach (int i in array)
        {
            if (dict.ContainsKey(i))
            {
                dict[i]++;
                if (dict[i] > maxValue)
                    maxValue = dict[i];
            }
                
            else
            {
                dict.Add(i, 1);
                maxValue = maxValue>1?maxValue:1;
            }
                
        }
        
        foreach (int n in dict.Keys)
        {
            if (dict[n] == maxValue)
            {
                list.Add(n);
                answer = n;
            }
                
        }
        
        if (list.Count > 1)
            return -1;
        return answer;
    }
}