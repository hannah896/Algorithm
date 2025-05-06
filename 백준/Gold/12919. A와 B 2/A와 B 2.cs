using System;

namespace Baekjoon12919
{
    class Program
    {
        static string S, T;
        static bool found = false;

        static void DFS(string current)
        {
            if (found) return;

            if (current.Length == S.Length)
            {
                if (current == S)
                    found = true;
                return;
            }

            if (current.Length <= S.Length) return;

            // 1. 끝이 A면 A 제거하고 계속
            if (current[current.Length - 1] == 'A')
            {
                DFS(current.Substring(0, current.Length - 1));
            }

            // 2. 시작이 B가 아니라 → 뒤집었을 때 끝이 B인 경우
            // 즉, 뒤집고 나서 B 제거
            if (current[0] == 'B')
            {
                char[] arr = current.ToCharArray();
                Array.Reverse(arr);
                string reversed = new string(arr);

                if (reversed[reversed.Length - 1] == 'B')
                {
                    DFS(reversed.Substring(0, reversed.Length - 1));
                }
            }
        }

        static void Main(string[] args)
        {
            S = Console.ReadLine();
            T = Console.ReadLine();

            DFS(T);
            Console.WriteLine(found ? 1 : 0);
        }
    }
}
