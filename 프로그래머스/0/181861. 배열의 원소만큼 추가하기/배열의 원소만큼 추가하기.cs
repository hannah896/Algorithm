using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        return arr.SelectMany(n => Enumerable.Repeat(n, n)).ToArray();
    }
}