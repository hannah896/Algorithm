using System;
using System.Collections.Generic;

public class Solution 
{
    private Dictionary<int, int> dict = new Dictionary<int, int>();
    public int solution(int a, int b, int c, int d) 
    {
        InputDict(a);
        InputDict(b);
        InputDict(c);
        InputDict(d);
        
        if(dict.Keys.Count == 4)
        {
            int min = int.MaxValue;
            foreach (int j in dict.Keys)
            {
                if (min > j)
                    min = j;
            }
            return min;
        }
        
        else if(dict.Keys.Count == 3)
        {
            int[] pqr = new int[3];
            int idx = 1;
            foreach (int key in dict.Keys)
            {
                if (dict[key] == 2)
                {
                    pqr[0] = key;
                    continue;
                }
                pqr[idx] = key;
                idx++;
            }
            return pqr[1] * pqr[2];
        }
        
        else if(dict.Keys.Count == 2)
        {
            int[] pq = new int[2];
            int idx = 0;
            bool flag = false;
            
            foreach (int key in dict.Keys)
            {
                if (dict[key] == 2)
                    flag = true;
                if (!flag)
                {
                    if (dict[key] == 3)
                        pq[0] = key;
                    else
                        pq[1] = key;
                }
                else
                {
                    pq[idx] = key;
                    idx++;                    
                }
            }
            if (flag)
                return (pq[0] + pq[1]) * (Math.Abs(pq[0] - pq[1]));
            
            return (10 * pq[0] +  pq[1])*(10 * pq[0] +  pq[1]);
        }
        
        return a* 1111;
    }
    
    private void InputDict(int n)
    {
        if (dict.ContainsKey(n))
        {
            dict[n]++;
            return;
        }
        dict.Add(n, 1);
    }
}