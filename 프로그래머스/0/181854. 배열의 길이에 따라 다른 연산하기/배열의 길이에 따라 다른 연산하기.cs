using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        //짝수
        if (arr.Length % 2 == 0) 
        {
            if (arr.Length == 1) 
            {
                return arr;
            }
            for (int i = 1; i < arr.Length; i += 2) 
            {
                arr[i] += n;
            }
        }
        //홀수
        else 
        {
            if (arr.Length == 1) 
            {
                arr[0] += n;
                return arr;
            }
            for (int i = 0; i < arr.Length; i += 2) 
            {
                arr[i] += n;
            }
        }
        
        return arr;
    }
}