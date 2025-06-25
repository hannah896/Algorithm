public class Solution
{
    public long solution(int n)
    {
        long one = 1;
        long two = 2;

        long ans = 0;

        if (n == 1)
        {
            return one;
        }
        else if (n == 2)
        {
            return two;
        }

        for (int i = 0; i < n - 2; i++)
        {
            ans = one + two;
            if (ans > 1234567)
            {
                ans %= 1234567;
            }
            one = two;
            two = ans;
        }

        return ans;
    }
}