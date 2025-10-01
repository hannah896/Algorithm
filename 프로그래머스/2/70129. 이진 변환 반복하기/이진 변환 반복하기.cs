using System;

public class Solution {
    public int[] solution(string s) 
    {
        int zeroCount = 0;
        int count = 0;
        
        int num = 0;
        
        bool _flag = true;
            
        foreach(char ch in s)
        {
            if (ch.Equals('0'))
            {
                zeroCount++;
                _flag = false;
            }
            else
            {
                num++;
            }
        }
        count++;
        
        while(true)
        {
            int length = 0;
            string value = Convert.ToString(num, 2);
            
            if (value.Equals("1"))
                break;
            foreach(char ch in value)
            {
                if (ch.Equals('0'))
                {
                    zeroCount++;
                }
                else
                {
                    length++;
                }
            }
            
            num = length;
            count++;
        }
        
        int[] result = {count, zeroCount};
        return result;
    }
}