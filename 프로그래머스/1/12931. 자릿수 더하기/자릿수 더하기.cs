using System;

public class Solution {
    public int solution(int n) 
    {
        string str = n.ToString();
        int sum = 0;
        
        foreach (char ch in str)
        {
            sum += int.Parse(ch.ToString());
        }
        return sum;
    }
}