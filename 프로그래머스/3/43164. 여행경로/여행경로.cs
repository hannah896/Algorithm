using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Solution
{
    Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
    List<(string, string)> _tickets = new List<(string, string)>();
    
    bool[] visited;
    string[] result;
    List<string> route = new List<string>();
    int ticketCount; 
    bool isEnd;

    private void DFS(string key)
    {
        route.Add(key);
        
        // Debuging();

        if (route.Count == ticketCount + 1)
        {
            isEnd = true;
            result = route.ToArray();
            return;
        }
        
        if (!dict.ContainsKey(key))
            return;
        
        foreach (int index in dict[key])
        {
            string item = _tickets[index].Item2;
  
            if (visited[index])
                continue;
            

            visited[index] = true;

            DFS(item);

            if (!isEnd)
            {
                visited[index] = false;
                route.RemoveAt(route.Count - 1);
            }
        }
    }

    public string[] solution(string[,] tickets)
    {
        ticketCount = tickets.GetLength(0);
        visited = new bool[ticketCount];
        
        for (int i = 0; i < ticketCount; i++)
            _tickets.Add((tickets[i, 0], tickets[i, 1]));
        
        _tickets.Sort();
        
        for (int i = 0; i < _tickets.Count; i++)
        {
           if (!dict.ContainsKey(_tickets[i].Item1))
                dict.Add(_tickets[i].Item1, new List<int>());
            
            dict[_tickets[i].Item1].Add(i);
        }
        

        DFS("ICN");
        return result;
    }

    private void Debuging()
    {
        foreach (var x in route)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }

    private bool CanVisit((string, string) tick)
    {
        for (int i = 0; i< _tickets.Count; i++)
        {
            var t = _tickets[i];
            if (t.Item1.Equals((tick.Item1)) && t.Item2.Equals((tick.Item2)))
            {
                return true;
            }
        }
        return false;
    }
}