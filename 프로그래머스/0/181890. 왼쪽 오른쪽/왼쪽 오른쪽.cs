using System;
using System.Linq;

public class Solution 
{
    public string[] solution(string[] str_list) 
    {
        if (Array.IndexOf(str_list, "l") == -1 && Array.IndexOf(str_list, "r") == -1) return new string[]{};
        return (Array.IndexOf(str_list, "l") == -1 ? int.MaxValue: Array.IndexOf(str_list, "l"))
            < 
            (Array.IndexOf(str_list, "r") == -1 ? int.MaxValue: Array.IndexOf(str_list, "r")) 
            ? str_list.Take(Array.IndexOf(str_list, "l")).ToArray() 
            :
            str_list.Skip(Array.IndexOf(str_list, "r")+1).ToArray();
    }
}