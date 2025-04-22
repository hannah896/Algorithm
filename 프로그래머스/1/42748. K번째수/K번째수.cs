using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        List<int> answer = new List<int>();
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int _i = commands[i, 0] -1;
            int _j = commands[i, 1] - 1;
            int _k = commands[i, 2] - 1;
            List<int> list = new List<int>();
            for (int j = _i; j <= _j; j++)
            {
                list.Add(array[j]);
            }
            
            list.Sort();
            answer.Add(list[_k]);
        }
        return answer.ToArray();
    }
}