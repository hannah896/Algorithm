using System;
using System.Linq;

public class Solution 
{
    public string[] solution(string[] strArr) 
    {
        return strArr.Select((x, index) => index %2 != 0? x.ToUpper(): x.ToLower()).ToArray();
    }
}