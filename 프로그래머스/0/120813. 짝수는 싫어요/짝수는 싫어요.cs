using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n) 
    {
        List<int> res = new List<int>();
        
        for (int i = 1; i<=n ; i++)
        {
            if (i%2 == 1)
                res.Add(i);
        }
        return res.ToArray();
    }
}