using System.Text;
using System;

public class Solution
{
    private StringBuilder sb = new StringBuilder();
    
    public string solution(string[] seoul)
    {
        int idx = Array.IndexOf(seoul, "Kim");
        sb.Append($"김서방은 {idx}에 있다");
        return sb.ToString();
    }
}