using System;
using System.Linq;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        return Enumerable.Range(0, myString.Length - pat.Length + 1).Select(x => myString.Substring(x).IndexOf(pat) != -1 ?  myString.Substring(x).IndexOf(pat)+ x: -1).Distinct().Count( x=> x >= 0);
    }
}