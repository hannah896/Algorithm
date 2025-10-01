using System;

public class Solution {
    public int solution(int n) 
    {
        if (n%2 == 0)
        {
            int k_2 = n/2;
            return 2 * k_2 * (k_2+1) * (2*k_2 +1)/3;
        }
        
        int k_1 = (n + 1) /2;
        return k_1 * k_1;
    }
}