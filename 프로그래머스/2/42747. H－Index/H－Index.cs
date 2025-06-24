using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
    {
        List<int> notes;
        int max = 0;
        public int solution(int[] citations)
        {
            notes = new List<int>(citations);
            notes.Sort();
            if (notes[0] >= notes.Count)
                return notes.Count;
            int avg = (int)(notes.Count / 2);
            int ans = Check(avg);
            return ans;
        }
        private int Check(int avg)
        {
            int higher = 0;
            foreach(int a in notes)
            {
                if( a>= avg)
                    higher++;
            }
            if (max < avg)
            {
                if (higher<avg) //to high
                {
                    return Check(avg - 1);
                }
                else
                {
                    max = avg;
                    return Check(avg + 1);
                }
            }
            return max;
        }

    }