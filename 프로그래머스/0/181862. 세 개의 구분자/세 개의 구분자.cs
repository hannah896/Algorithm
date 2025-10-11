using System;
using System.Linq;

public class Solution 
{
    public string[] solution(string myStr) 
    {
        return myStr.Replace("a", " ").Replace("b", " ").Replace("c", " ").Split(" ").Where(x => !x.Equals("")).ToArray().Length == 0? new string[] { "EMPTY" }: myStr.Replace("a", " ").Replace("b", " ").Replace("c", " ").Split(" ").Where(x => !x.Equals("")).ToArray();
    }
}