using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) 
    {
        return strArr.Where(x => x.IndexOf("ad") == -1).ToArray();
    }
}