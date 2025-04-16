using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        if (myString.ToLower().IndexOf(pat.ToLower()) > -1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}