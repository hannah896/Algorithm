using System;

public class Solution {
    public int solution(int n) {
        int ans = 2;
        while(true) 
        {
            if (n%ans == 1) 
            {
                break;
            }
            ans++;
        }
        return ans;
    }
}