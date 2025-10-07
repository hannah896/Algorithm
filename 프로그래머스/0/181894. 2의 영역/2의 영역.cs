using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        int start = Array.IndexOf(arr, 2);
        Console.WriteLine(start);
        if (start == -1)
            return new int[] {-1};
        int[] answer = arr
            .Skip(start)
            .Take(Array.LastIndexOf(arr, 2) - start +1)
            .ToArray();
        return answer;
    }
}