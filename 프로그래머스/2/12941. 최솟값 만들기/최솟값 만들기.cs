using System.Linq;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        return A.OrderBy(x => x).Zip(B.OrderByDescending(x => x), (a, b) => a * b).Sum();
    }
}