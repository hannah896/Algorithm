using System;

class Solution
{
    private int curDist;
    private int power;

    public int solution(int n)
    {
        while (true) 
        {
            if (n % 2 == 1)
            {
                power++;
            }

            if (n / 2 == 0)
            {
                break;
            }
            else
            {
                n /= 2;
            }
        }

        return power;
    }
}