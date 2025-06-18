using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        Dictionary<int, int> mandarin = new Dictionary<int, int>();
        List<int> mandarinSize = new List<int>();

        int answer = 0;

        for (int i = 0; i<tangerine.Length; i++)
        {
            if (mandarin.ContainsKey(tangerine[i]))
            {
                mandarin[tangerine[i]]++;
            }
            else
            {
                mandarin.Add(tangerine[i], 1);
            }
        }

        
        foreach(int key in mandarin.Keys)
        {
            mandarinSize.Add(mandarin[key]);
        }
        mandarinSize.Sort(new Comparison<int> ((n1, n2) => n2.CompareTo(n1)));

        foreach(int num in mandarinSize)
        {
            k -= num;
            answer++;
            if (k <= 0)
            {
                return answer;
            }
        }

        return answer;
    }
}