using System;
using System.Text;
using System.Linq;

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            my_string = Change(my_string, queries[i, 0], queries[i, 1]);
        }
        return my_string;
    }

    private string Change(string str, int s, int e)
    {
        StringBuilder sb = new StringBuilder();
        
        string st = str.Substring(0, s);
        string ran = new string(str.Substring(s, e-s+1).Reverse().ToArray());
        string ed = str.Substring(e + 1, str.Length - e -1);
        
        sb.Append(st);
        sb.Append(ran);
        sb.Append(ed);
        return sb.ToString();
    }
}