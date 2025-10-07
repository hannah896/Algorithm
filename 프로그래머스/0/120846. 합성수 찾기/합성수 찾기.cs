using System;

public class Solution 
{
    public int solution(int n) 
    {
        bool[] isPrime = new bool[n+1];
        isPrime[0] = true;
        isPrime[1] = true;
        
        for (int i = 2; i<=n; i++)
        {
            if (!isPrime[i])
            {
                for (int j = i*i; j <= n; j += i)
                {
                    isPrime[j] = true;
                }
            }
        }
        
        int answer = -2;
        
        foreach (bool p in isPrime)
            if (p)
                answer++;
        
        return answer;
    }
}