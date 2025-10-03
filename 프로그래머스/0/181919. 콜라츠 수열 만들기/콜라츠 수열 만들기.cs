using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) 
    {
        List<int> record = new List<int>();
        
        while(n != 1)
        {
            record.Add(n);
            if (n % 2 == 0)
                n /= 2;
            
            else
            {
                n *=3;
                n += 1;
            }
        }
        record.Add(n);
        return record.ToArray();
    }
}