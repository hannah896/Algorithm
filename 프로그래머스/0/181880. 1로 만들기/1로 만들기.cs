using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer = 0;
        foreach (int n in num_list)
        {
            int num = n;
            while (num != 1)
            {
                if (num %2 == 0)
                    num/=2;
                else
                {
                    num -=1 ;
                    num /=2;
                }
                answer++;
            }
        }
        
        return answer;
    }
}