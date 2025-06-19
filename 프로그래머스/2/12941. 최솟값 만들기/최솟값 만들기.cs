using System;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        int size = A.Length;
        Array.Sort(A);
        Array.Sort(B);
        Array.Reverse(B);

        int total = 0;
        for (int i = 0; i < size; i++)
        {
            total += A[i] * B[i];
        }
        return total;
    }
}