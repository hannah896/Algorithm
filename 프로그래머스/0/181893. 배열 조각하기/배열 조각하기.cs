using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr, int[] query) 
    {
        for (int i = 0; i<query.Length; i++)
            arr = i % 2 ==0 ? arr.Take(query[i]+1).ToArray(): arr.Skip(query[i]).ToArray();
        return arr;
    }
}