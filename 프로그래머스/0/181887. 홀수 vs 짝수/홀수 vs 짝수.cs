using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        Console.WriteLine();
        Console.WriteLine();
        return Enumerable.Range(0, (num_list.Length-1)/2+1).Select(x=> num_list[2*x]).Sum() > Enumerable.Range(0, num_list.Length/2).Select(x=> num_list[2*x+1]).Sum()? Enumerable.Range(0, (num_list.Length-1)/2+1).Select(x=> num_list[2*x]).Sum() : Enumerable.Range(0, num_list.Length/2).Select(x=> num_list[2*x+1]).Sum();
    }
}