using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] A, int[] B) {
       int sum_min = 0;

            List<int> A_temp = new List<int>(A);
            List<int> B_temp = new List<int>(B);

            A_temp.Sort();
            B_temp.Sort();
            B_temp.Reverse();

            for (int i = 0; i < A.Length; i++)
            {
                sum_min += A_temp[i] * B_temp[i];
            }

        return sum_min;
    }
}