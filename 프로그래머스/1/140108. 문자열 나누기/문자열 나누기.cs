using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string s)
    {
        s = s.ToLower();
        char? x = s[0];
        int xCount = 0;
        int notX = 0;

        string str = string.Empty;
        List<string> list = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            if (x == null)
            {
                x = s[i];
                xCount++;
                str += s[i];
            }
            else
            {
                str += s[i];
                if (x == s[i])
                {
                    xCount++;
                }
                else
                {
                    notX++;
                }
                
                if (xCount == notX)
                {
                    list.Add(str);
                    str = string.Empty;
                    x = null;
                    xCount = 0;
                    notX = 0;
                }
            }
        }

        if (str != string.Empty)
        {
            list.Add(str);
        }

        int answer = list.Count;
        return answer;
    }
}