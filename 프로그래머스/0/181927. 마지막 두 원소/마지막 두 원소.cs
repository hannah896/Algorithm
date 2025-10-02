using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        List<int> numList = num_list.ToList();
        int lastIndex = numList.Count-1;
        int _value = numList[lastIndex] > numList[lastIndex-1] ? numList[lastIndex] - numList[lastIndex-1] : numList[lastIndex]*2;
        numList.Add(_value);
        return numList.ToArray();
    }
}