using System;

public class Solution 
{
    public int solution(int n, int k) 
    {
        int m = n/10;
        int sum = n * 12 + (k-m)*2;
        return sum*1000;
    }
}