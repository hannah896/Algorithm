using System;

public class Solution {
    public int solution(string number) 
    {
        int sum = 0;
        foreach(char n in number)
        {
            sum += int.Parse(n.ToString());
            sum %= 9;
        }
        return sum;
    }
}