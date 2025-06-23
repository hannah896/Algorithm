public class Solution
{
    int[] arr;

    private int DFS(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        if (arr[n] == -1)
        {
            arr[n] = DFS(n - 1) % 1234567 + DFS(n - 2) % 1234567;
        }
        return arr[n] % 1234567;
    }

    public int solution(int n)
    {
        arr = new int[n + 1];

        for (int i = 0; i < n + 1; i++)
        {
            arr[i] = -1;
        }
        int ans = DFS(n);
        return ans ;
    }
}