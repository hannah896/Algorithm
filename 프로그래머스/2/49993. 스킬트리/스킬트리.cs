using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int solution(string skill, string[] skill_trees)
    {
        char[] h = new char[skill.Length];

        for (int i = 0; i<skill.Length;i++)
            h[i] = skill[i];

        int result = 0;

        foreach (string skilltree in skill_trees)
        {
            List<char> list = new List<char>();
            foreach (char c in skilltree)
            {
                if (h.Contains(c))
                {
                    list.Add(c);
                }
            }

            bool flag = true;
            for(int i =0; i< list.Count; i++)
            {
                if (list[i] != skill[i])
                {
                    flag = false;
                }
            }
            if (flag)
            {
                result++;
            }
        }

        return result;
    }
}
