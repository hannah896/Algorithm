using System;

public class Solution 
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2) 
    {
        int[] answer = new int[2];
        
        if(denom2 % denom1 == 0 || denom1%denom2 == 0)
        {
            int val = denom1>denom2 ? denom1:denom2;
            answer[0] = denom2 == val ? val/denom1 * numer1 + numer2 : val/denom2 * numer2 +numer1;
            answer[1] = val;
            
            int maxValue = answer[0] > answer[1] ? answer[0] : answer[1];
            for (int i = maxValue; i>= 2; i--)
            {
                if (answer[0] %i == 0 && answer[1] %i == 0)
                {
                    answer[0] /= i;
                    answer[1] /= i;
                }
            }
        }
        else
        {
            answer[0] = numer1* denom2 + numer2 * denom1;
            answer[1] = denom1 * denom2;
            int maxValue = answer[0] > answer[1] ? answer[0] : answer[1];
            
            for (int i = maxValue; i>= 2; i--)
            {
                if (answer[0] %i == 0 && answer[1] %i == 0)
                {
                    answer[0] /= i;
                    answer[1] /= i;
                }
            }
        }
        
        return answer;
    }
}