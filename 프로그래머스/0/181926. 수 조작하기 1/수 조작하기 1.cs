using System;

public class Solution {
    public int solution(int n, string control) 
    {
        foreach (char ch in control)
        {
            switch(ch)
            {
                case 'w':
                    n++;
                    break;
                case's':
                    n--;
                    break;
                case 'd':
                    n += 10;
                    break;
                case 'a':
                    n -= 10;
                    break;
            }
        }
        return n;
    }
}