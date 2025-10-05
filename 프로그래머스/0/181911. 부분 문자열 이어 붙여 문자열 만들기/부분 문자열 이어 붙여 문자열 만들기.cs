using System;
using System.Text;

public class Solution 
{
    public string solution(string[] my_strings, int[,] parts) 
    {
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i< my_strings.Length; i++)
        {
            sb.Append(my_strings[i].Substring(parts[i, 0], parts[i, 1] - parts[i, 0] +1));
        }
        
        return sb.ToString();
    }
}