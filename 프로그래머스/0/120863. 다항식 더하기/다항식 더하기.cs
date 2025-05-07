using System;

public class Solution
{
    private int x = 0;
    private int defalut = 0;
    private void AddValue(string v)
    {
        if (v.Contains("x"))
        {
            string n = v.Split('x')[0];
            if (int.TryParse(n, out int num))
            {
                x += num;
            }
            else
            {
                x += 1;
            }
            
        }
        else
        {
            defalut += int.Parse(v);
        }
    }
    public string solution(string polynomial)
    {
        polynomial = polynomial.Trim();
        string[] s = polynomial.Split("+");
        
        foreach (string v in s)
        {
            AddValue(v);
        }
        string answer = string.Empty;

        //0인경우
        if (x == 0 && defalut == 0)
        {
            return "0";
        }
        //x처리
        if (x != 0)
        {
            if (x == 1)
            {
                answer += "x";
            }
            else
            {
                answer += $"{x}x";
            }   
        }
        //실수 처리
        if (defalut != 0)
        {
            if (defalut < 0)
            {
                if (x != 0)
                {
                    answer += $" ";
                }
                answer += $"- {defalut}";
            }
            else
            {
                if (x != 0)
                {
                    answer += $" + ";
                }
                answer += $"{defalut}";
            }
        }
        return answer;
    }
}