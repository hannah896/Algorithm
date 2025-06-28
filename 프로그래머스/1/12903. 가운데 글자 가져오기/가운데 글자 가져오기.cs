using System;

public class Solution
{
    public string solution(string s)
    {
        int len = s.Length / 2;
        string answer = s[len].ToString();
        if (s.Length % 2 == 0)
        {
            answer = s[len- 1] + s[len].ToString();
            return answer;
        }
        return answer;
    }
}