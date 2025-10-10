using System;
using System.Linq;

public class Solution {
    public string[] solution(string myString) 
    {
        return myString.Split("x").Where(x => !x.Equals("")).OrderBy(x => x).ToArray();
    }
}