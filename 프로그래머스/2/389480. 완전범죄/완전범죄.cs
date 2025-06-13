using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Solution
{
    private int size;

    private int n;
    private int m;
    private int[,] info;

    //방문배열 index, countA, countB
    private HashSet<(int, int, int)> visited = new HashSet<(int, int, int)> ();

    //A의 최소값
    private int answer = Int32.MaxValue;

    private void DFS(int index = 0, int countA = 0, int countB = 0)
    {
        //이미 계산된 연산이거나 값이 넘어갔을 경우
        if (answer <= countA ||visited.Contains((index, countA, countB)))
            return;

        visited.Add((index, countA, countB));

        //다 훔친 경우
        if (index == size)
        {
            //A의 최소값
            answer = Math.Min(answer, countA);
            return;
        }

        bool canA = countA + info[index, 0] < n;
        bool canB = countB + info[index, 1] < m;

        if (!canA&&!canB)
            return;

        // A도둑이 가져갔을 때
        if (canA)
        {
            DFS(index + 1, countA + info[index, 0], countB);
        }

        if (canB)
        {
            // B도둑이 가져갔을 때
            DFS(index + 1, countA, info[index, 1] +  countB);
        }
        
    }

    public int solution(int[,] info, int n, int m)
    {
        size = info.GetLength(0);
        this.info = new int[size, 2];
        this.info = info;
        this.n = n;
        this.m = m;

        DFS(0);

        return answer == Int32.MaxValue ? -1 : answer;
    }
}