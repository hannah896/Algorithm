using System;
using System.Collections.Generic;
  public class Solution
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        HashSet<string> idList = new HashSet<string>();
        Dictionary<string, List<string>> userReport = new Dictionary<string, List<string>>(); //유저가 신고한 유저 딕셔너리
        Dictionary<string, int> userReportCount = new Dictionary<string, int>(); //유저가 몇번 신고 당했는지 딕셔너리
        int[] answer = new int[id_list.Length];

        foreach (string rep in report)
        {
            idList.Add(rep);
        }

        foreach (string rep in idList)
        {
            string[] _log = rep.Split(" ");
            //신고자가 신고 전적이 있다면
            if (userReport.ContainsKey(_log[0]))
            {
                //새로운 녀석 추가하기
                userReport[_log[0]].Add(_log[1]);
                //이미 신고당한 전적이 있는 녀석이라면 
                if (userReportCount.ContainsKey(_log[1]))
                {
                    userReportCount[_log[1]] += 1;
                }
                else
                {
                    userReportCount.Add(_log[1], 1);
                }
            }
            //신고자가 신고 전적이 없다면
            else
            {
                //누구를 신고했는지 담기
                userReport.Add(_log[0], new List<string>());
                userReport[_log[0]].Add(_log[1]);
                //이미 신고당한 전적이 있는 녀석이라면 
                if (userReportCount.ContainsKey(_log[1]))
                {
                    userReportCount[_log[1]] += 1;
                }
                else
                {
                    userReportCount.Add(_log[1], 1);
                }
            }
        }

        for (int i = 0; i < id_list.Length; i++)
        {
            string id = id_list[i];

            List<string> targets = new List<string>();
            if (userReport.ContainsKey(id))
            {
                targets = userReport[id];
            }

            int num = 0;

            foreach (string target in targets)
            {
                if (userReportCount.ContainsKey(target))
                {
                    if (userReportCount[target] >= k)
                    {
                        num++;
                    }
                }
            }
            answer[i] = num;
        }

        return answer;
    }
}