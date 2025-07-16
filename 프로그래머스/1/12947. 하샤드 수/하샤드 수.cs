public class Solution
{
    public bool solution(int x)
    {
        if (x <= 10)
        {
            return true;
        }

        int[] num = new int[5];
        int xCopy = x;

        int div = 10000;

        for (int i = 1; i < 5; i++)
        {
            div /= 10;

            num[i] = x/ div;
            x %= div;
        }

        int sum = 0;

        foreach (int n in num)
        {
            sum += n;
        }

        if (xCopy % sum == 0)
        {
            return true;
        }

        return false;
    }
}
