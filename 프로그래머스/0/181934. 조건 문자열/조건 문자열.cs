using System;

public class Solution
{
    public int solution(string ineq, string eq, int n, int m)
    {
        bool i = ineq.Equals("<");
        bool e = eq.Equals("=");
        
        if (i)
        {
            if (n < m)
            {
                return 1;
            }
            else
            {
                if (e&&(n == m))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        else
        {
            if (n > m)
            {
                return 1;
            }
            else
            {
                if (e && (n == m))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}