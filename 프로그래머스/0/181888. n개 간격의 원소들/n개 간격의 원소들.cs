
using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] num_list, int n) 
    {
        return Enumerable.Range(0, (num_list.Length-1)/n+1).Select(x=> num_list[x*n]).ToArray();
    }
}