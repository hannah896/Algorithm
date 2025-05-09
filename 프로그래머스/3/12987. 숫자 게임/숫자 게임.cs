using System;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        Array.Sort(A);
        Array.Reverse(A);
        Array.Sort(B);
        Array.Reverse(B);

        int answer = 0;
        int n = A.Length;

        int idxB = 0;
        int usedIdx = n - 1;

        
        for (int i = 0; i < n; i++)
        {
            if (A[i] >= B[idxB])
            {
                usedIdx -= 1;
                continue;
            }
            else
            {
                idxB++;
                answer++;
            }
        }
        
        return answer;
    }
}
