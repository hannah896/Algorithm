using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] citations)
    {
        Array.Sort(citations);

        int ans = 0;
        int maxVal = citations.Max();

        for (int i = 0; i < maxVal; i++)
        {
            int count = 0;
            foreach(int c in citations)
            {
                if (c >= i)
                {
                    count++;
                }
            }
            if (i <= count)
            {
                ans = Math.Max(ans, i);
            }
            else
            {
                break;
            }
        }

        return ans;
    }
}