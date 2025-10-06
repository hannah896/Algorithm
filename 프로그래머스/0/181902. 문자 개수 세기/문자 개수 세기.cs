using System;
using System.Globalization;

public class Solution 
{
    public int[] solution(string my_string) 
    {
        int[] answer = new int[52];
        
        foreach (char ch in my_string)
        {
            int v = (int)ch;
            v -= 65;
            
            if (v >26)
                v -= 6;
            
            answer[v]++;
        }
        return answer;
    }
}