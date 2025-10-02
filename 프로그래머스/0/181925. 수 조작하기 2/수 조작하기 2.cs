using System;
using System.Text;

public class Solution {
    public string solution(int[] numLog) 
    {
        StringBuilder sb = new StringBuilder();
        int cur = numLog[0];
        
        for (int i = 1; i< numLog.Length; i++)
        {
            int input = numLog[i] - cur;
            
            switch(input)
            {
                case 1:
                    sb.Append("w");
                    cur = numLog[i];
                    break;
                case -1:
                    sb.Append("s");
                    cur = numLog[i];
                    break;
                case 10:
                    sb.Append("d");
                    cur = numLog[i];
                    break;
                case -10:
                    sb.Append("a");
                    cur = numLog[i];
                    break;
            }
        }
        return sb.ToString();
    }
}