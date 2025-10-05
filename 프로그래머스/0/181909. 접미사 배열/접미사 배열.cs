using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string my_string) 
    {
        List<string> result = new List<string>();
        for(int i = 0; i< my_string.Length; i++)
        {
            result.Add(my_string.Substring(i));
        }
        string[] arr = result.ToArray();
        Array.Sort(arr);
        return arr;
    }
}