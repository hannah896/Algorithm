using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int[] arrayPre;
    public int[] arrayCount;

    public int NumChange(int x)
    {
        if (x >= 50 && (x % 2 == 0))
        {
            return x / 2;
        }
        else if (x < 50 && (x % 2 == 1))
        {
            return x * 2 + 1;
        }
        return x;
    }

    public void ArrayChange(int[] arr)
    {
        arrayCount = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            int x = arr[i];
            int count = 0;
            while (true)
            {
                int x1 = NumChange(x);
                if (x == x1)
                {
                    arrayCount[i] = count;
                    break;
                }
                x = x1;
                count++;
            }
        }
    }
    public int solution(int[] arr)
    {
        arrayPre = arr;
        ArrayChange(arr);
        
        return arrayCount.Max();
    }
}
