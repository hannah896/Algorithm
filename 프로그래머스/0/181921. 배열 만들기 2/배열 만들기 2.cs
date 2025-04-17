using System;
using System.Collections.Generic;

public class Solution
{
    List<int> answer = new List<int>();
    private void DFS(string str, int l, int r)
    {
        int num = int.Parse(str);

        if (num > r)
        {
            return;
        }
        if (num >= l && num <= r)
        {
            answer.Add(num);
        }
        
        DFS(str + "0", l, r);        
        DFS(str + "5", l, r);
    }

    public int[] solution(int l, int r)
    {
        int length = (int)MathF.Pow(2, r.ToString().Length - 1);

        DFS("5", l, r);

        answer.Sort();
        if(answer.Count == 0)
        {
            answer.Add(-1);
        }
        return answer.ToArray();
    }
}