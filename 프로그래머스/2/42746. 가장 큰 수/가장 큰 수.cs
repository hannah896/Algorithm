using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    int len;
    //두수를 합친 수를 만들어서 반환
    private int MakeInt(int front, int back)
    {
        string result = front.ToString() + back.ToString();
        return int.Parse(result);
    }

    public List<int> Sortingnumbers(List<int> nums)
    {
        if (nums.Count <= 1)
        {
            return nums;
        }
        int pivotIdx = nums.Count / 2 - 1;
        int pivotValue = nums[pivotIdx];

        List<int> front = new List<int>();
        int frontIndex = 0;

        List<int> back = new List<int>();
        int backIndex = pivotIdx + 1;

        List<int> pivot = new List<int>();

        for (int i = 0; i < nums.Count; i++)
        {
            int pivotFirst = MakeInt(pivotValue, nums[i]);
            int numsFirst = MakeInt(nums[i], pivotValue);

            //피벗보다 우선순위가 낮을때 
            if (pivotFirst > numsFirst)
            {
                back.Add(nums[i]);
                backIndex++;
            }
            //피벗과 값이 같을때
            else if (pivotFirst == numsFirst)
            {
                pivot.Add(nums[i]);
            }
            //피벗보다 우선순위가 높을때
            else
            {
                front.Add(nums[i]);
                frontIndex++;
            }
        }

        front = Sortingnumbers(front);
        back = Sortingnumbers(back);

        List<int> result = new List<int>();
        result.AddRange(front);
        result.AddRange(pivot);
        result.AddRange(back);

        return result;
    }

    public string solution(int[] numbers)
    {
        bool isZero = true;

        foreach(int i in numbers)
        {
            if (i != 0)
            {
                isZero = false; 
            }
        }

        if (isZero)
        {
            return "0";
        }

        List<int> nums = numbers.ToList<int>();
        nums = Sortingnumbers(nums);

        return String.Join(string.Empty, nums);
    }
}