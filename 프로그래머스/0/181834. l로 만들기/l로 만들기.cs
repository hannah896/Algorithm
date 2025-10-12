using System;
using System.Linq;

public class Solution {
    public string solution(string myString) 
    {
        return new string(myString.Select(x=> x < 'l' ? 'l':x).ToArray());
    }
}