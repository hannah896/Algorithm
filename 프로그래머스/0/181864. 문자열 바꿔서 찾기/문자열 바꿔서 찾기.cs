using System;
using System.Linq;

public class Solution {
    public int solution(string myString, string pat) 
    {
        Console.WriteLine();
        return new string(myString.Select(x => x.Equals('A')? 'B':'A').ToArray()).Contains(pat)?1:0;
    }
}