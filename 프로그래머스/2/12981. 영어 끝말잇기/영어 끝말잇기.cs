using System;
using System.Collections.Generic;
using System.Xml.Serialization;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        HashSet<string> word = new HashSet<string>();
        int[] answer = new int[2];
        int num_c = 0;
        int num_p = 0;
        char end = ' ';

        for (int i = 0; i< words.Length; i++)
        {
            string wordValue = words[i];
            //시작과 끝이 맞는지
            char first = wordValue[0];

            if (first != end &&(i != 0))
            {
                //i번째 애가 틀림
                num_p = ((i + 1) % n);
                num_c = ((i + 1) / n) + 1;

                if (num_p == 0)
                {
                    num_p = n;
                    num_c -= 1;
                }

                break;
            }

            end = wordValue[wordValue.Length - 1];

            //이미 나온 단어의 경우
            if (word.Contains(wordValue))
            {
                //i번째 애가 틀림
                num_p = ((i + 1) % n);
                num_c = ((i + 1) / n) + 1;

                if (num_p == 0)
                {
                    num_p = n;
                    num_c -= 1;
                }
                
                break;
            }
            else
            {
                word.Add(wordValue);
            }
            
        }
        
        answer[0] = num_p;
        answer[1] = num_c;

        return answer;
    }
}