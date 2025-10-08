using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] num_list, int n) 
    {
        return Enumerable
            .Range(0, num_list.Length)
            .Select(x => num_list[(x+n)%num_list.Length])
            .ToArray();
    }
}