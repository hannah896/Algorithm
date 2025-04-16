public class Solution
{
    public int solution(string t, string p)
    {
        int count = 0;
        long valueT;
        long valueP;

        if (!long.TryParse(p.Substring(0, p.Length), out valueP))
        {
            valueP = 0;
        }

        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            if (!long.TryParse(t.Substring(i, p.Length), out valueT))
            {
                continue;
            }
            if (valueP >= valueT)
            {
                count++;
            }
        }
        return count;
     }
}