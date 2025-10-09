using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        return Enumerable.Range(0, 2).Select(x=> x==0? num_list.Where(v => v%2 == 0).Count():num_list.Where(v => v%2 != 0).Count()).ToArray();
    }
}