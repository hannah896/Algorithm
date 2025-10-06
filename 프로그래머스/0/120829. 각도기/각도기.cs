using System;

public class Solution {
    public int solution(int angle) 
    {
        if (angle == 90)
            return 2;
        else if (0< angle && angle<90)
            return 1;
        else if (angle < 180 && angle > 90)
            return 3;
        return 4;
    }
}