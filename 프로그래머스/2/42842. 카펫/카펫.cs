using System;

public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];
        int size = brown + yellow;
        
        for (int height = 3; height < size; height++)
        {
            int width = size / height;
            if (height* width != size)
            {
                continue;
            }
            if (yellow == (height-2) * (width -2))
            {
                answer = new int[2];
                answer[0] = width;
                answer[1] = height;
                return answer;
            }
        }
        return answer;
    }
}