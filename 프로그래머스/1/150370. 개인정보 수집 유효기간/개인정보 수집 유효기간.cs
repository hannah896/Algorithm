using System;
using System.Collections.Generic;
public class Date
{
    public int year;
    public int month;
    public int day;

    public Date(int year, int month, int day)
    {
        this.year = year;
        this.month = month;
        this.day = day;
    }

    public Date(string year, string month, string day)
    {
        this.year = int.Parse(year);
        this.month = int.Parse(month);
        this.day = int.Parse(day);
    }
}

public class Solution
{
    private Dictionary<string, int> terms = new Dictionary<string, int>();
    private List<Date> endDate = new List<Date>();

    private void SetDate(string date, string mon)
    {
        int m = terms[mon];

        string[] tDay = date.Split(".");

        int year = int.Parse(tDay[0]);
        int month = int.Parse(tDay[1]);
        int day = int.Parse(tDay[2]);

        month += m;

        while (month > 12)
        {
            month -= 12;
            year += 1;
        }
        endDate.Add(new Date(year, month, day));
    }

    public int[] solution(string today, string[] terms, string[] privacies)
    {
        string[] tod = today.Split(".");
        Date td = new Date(tod[0], tod[1], tod[2]);

        List<int> answer = new List<int>();

        foreach (string row in terms)
        {
            string[] pair = row.Split(" ");
            this.terms.Add(pair[0], int.Parse(pair[1]));
        }

        foreach (var privacy in privacies)
        {
            string[] pair = privacy.Split(" ");
            SetDate(pair[0], pair[1]);
        }

        for (int i = 0; i < endDate.Count; i++)
        {
            Date d = endDate[i];
            if (d.year > td.year)
            {
                continue;
            }
            else if (d.year < td.year)
            {
                answer.Add(i + 1);
            }
            else
            {
                if (d.month > td.month)
                {
                    continue;
                }
                else if (d.month < td.month)
                {
                    answer.Add(i + 1);
                }
                else
                {
                    if (d.day > td.day)
                    {
                        continue;
                    }
                    else
                    {
                        answer.Add(i + 1);
                    }
                }
            }
        }


        return answer.ToArray();
    }
}