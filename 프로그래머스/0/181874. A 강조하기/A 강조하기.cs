using System;
using System.Linq;

public class Solution 
{
    public string solution(string myString) 
    {
        return new string(myString.Select(x => x.Equals('a') || x.Equals('A')? 'A': Char.ToLower(x)).ToArray());
    }
}