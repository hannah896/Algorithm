using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) 
    {
        int[] answer = new int[queries.GetLength(0)];
        
        for (int i = 0; i< queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];
            int k = queries[i, 2];
            
            int minValue = int.MaxValue;
            for (int j = s; j<= e; j++)
            {
                int _val = arr[j] > k? arr[j]: -1;
                if (_val == -1)
                    continue;
                minValue = minValue > _val ? _val: minValue;
            }
            if (minValue == int.MaxValue)
                minValue = -1;
            answer[i] = minValue;
        }
        
        return answer;
    }
}