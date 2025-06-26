using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;


public class Solution
{
    string target;

    int ans = int.MaxValue;
    int count = 0;

    private void DFS(string word, List<string> words)
    {
        //단어변환 성공시
        if (word.Equals(target))
        {
            ans = Math.Min(count, ans);
            return;
        }

        foreach (string w in words)
        {
            if (CheckWord(w, word))
            {
                List<string> woords = words.ToArray().ToList();
                woords.Remove(w);
                count++;
                DFS(w, woords);
                count--;
            }
        }
    }

    private bool CheckWord(string w, string word)
    {
        int c = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (!w[i].Equals(word[i]))
            {
                c++;
            }
            if (c > 1)
        
            {
                return false;
            }
        }
        return true;
    }

    public int solution(string begin, string target, string[] words)
    {
        this.target = target;

        DFS(begin, words.ToList());

        if (ans == int.MaxValue)
        {
            return 0;
        }
        return ans;
    }
}