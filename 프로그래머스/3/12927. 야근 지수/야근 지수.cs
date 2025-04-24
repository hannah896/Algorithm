using System;

public class PriorityQueue
{
    public void Add(int value)
    {
        arr[size++] = value;

        int cur = size - 1;

        while (cur > 0)
        {
            int parent = (cur - 1) / 2;

            if (arr[parent] < arr[cur])
            {
                int temp = arr[cur];
                arr[cur] = arr[parent];
                arr[parent] = temp;

                cur = parent;
            }
            else
                break;
        }
    }



    public int Pop()
    {
        int ret = arr[0];
        arr[0] = arr[--size];

        int cur = 0;

        while (cur < size - 1)
        {
            int left = cur * 2 + 1;
            int right = left + 1;

            if (left >= size)
                break;

            if (right < size && arr[right] > arr[left])
                left = right;

            if (arr[left] > arr[cur])
            {
                int temp = arr[left];
                arr[left] = arr[cur];
                arr[cur] = temp;

                cur = left;
            }
            else
                break;
        }

        return ret;
    }

    public bool IsEmpty() => size == 0;


    int size = 0;
    int[] arr = new int[30000];
}
public class Solution
{
    public long solution(int n, int[] works)
    {
        long totalTired = 0;

        PriorityQueue que = new PriorityQueue();
        foreach (int work in works)
        {
            que.Add(work);
        }

        while (n > 0)
        {
            int high = que.Pop();
            if (high == 0)
            {
                return 0;
            }
            que.Add(high - 1);
            n--;
        }


        while (!que.IsEmpty())
        {
            int value = que.Pop();
            totalTired += (long)Math.Pow(value, 2);
        }

        return totalTired;
    }
}