using System;
using System.Collections.Generic;
public class Solution
{
    string numbers;

    List<int> mixNum = new List<int>();
    public bool IsPrime(int num)
    {
        if (num <2) return false;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public void DFS(string number, List<int> usedIndex)
    {
        int num;
        if (int.TryParse(number, out num))
        {
            if (!mixNum.Contains(num))
            {
                mixNum.Add(num);
            }
        }

        for (int idx = 0; idx < numbers.Length; idx++)
        {
            if (usedIndex.Contains(idx))
            {
                continue;
            }
            usedIndex.Add(idx);
            DFS(number + numbers[idx], usedIndex);
            usedIndex.Remove(idx);
        }
    }
    public int solution(string numbers)
    {
        int count = 0;
        this.numbers = numbers;
        DFS("", new List<int>());
        foreach (int num in mixNum)
        {
            if (IsPrime(num))
            {
                count++;
            }
        }
        return count;
    }
}