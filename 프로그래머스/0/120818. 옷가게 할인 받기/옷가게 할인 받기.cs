using System;

public class Solution 
{
    public int solution(int price) 
    {
        return price >= 500000? (int)(price* 0.80f): price>= 300000? (int)(price* 0.90f): price>= 100000? (int)(price* 0.95f): price;
    }
}