using System;

public class Solution {
    public int solution(string binomial) 
    {
        string[] arr = binomial.Split(" ");
        bool[] op = new bool[3]; // '+', '-', '*' 
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[2]);
        
        if (arr[1].Equals("+"))
            return a+b;
        else if(arr[1].Equals("-"))
            return a-b;
        else 
            return a*b;
    }
}