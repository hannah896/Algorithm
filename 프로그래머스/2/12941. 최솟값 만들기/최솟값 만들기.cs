using System;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        Array.Sort(A);
        Array.Sort(B);

        int total = 0;
        for (int i = 0; i < A.Length; i++)
        {
            total += A[i] * B[A.Length-1-i];
        }
        return total;
    }
}