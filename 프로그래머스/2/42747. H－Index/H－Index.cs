using System;
using System.Linq;

public class Solution {
            public int solution(int[] citations)
        {
            int answer = 0;
            for (int i = citations.Max(); i > answer; i--)
            {
                if (citations.Count(e => e >= i) >= i)
                {
                    answer = i;
                }
            }

            return answer;
        }
}