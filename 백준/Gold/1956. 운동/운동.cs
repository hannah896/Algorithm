namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaxValue = Int32.MaxValue/10;
            string[] ve= Console.ReadLine().Split(" ");
            
            int V = int.Parse(ve[0]);
            int E = int.Parse(ve[1]);

            //데이터가 담길곳
            int[,] graph = new int[V, V];
            for (int i = 0; i< V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    if (i == j)
                    {
                        graph[i, j] = 0;
                    }
                    else
                    {
                        graph[i, j] = MaxValue;
                    }
                }
            }

            for (int n = 0; n< E; n++)
            {
                string[] ijc = Console.ReadLine().Split(" ");
                int i = int.Parse(ijc[0])-1; 
                int j = int.Parse(ijc[1])-1; 
                int c = int.Parse(ijc[2]);

                graph[i, j] = c;
            }
            
            for (int k = 0; k < V; k++)
            {
                //i = 출발지
                for (int i = 0; i < V; i++)
                {
                    //j = 도착지
                    for (int j = 0; j < V; j++)
                    {
                        if (graph[i, k] == MaxValue || graph[k, j] == MaxValue)
                            continue;

                        int cost = graph[i, k] + graph[k, j];
                        graph[i, j] = Math.Min(graph[i, j], cost);
                    }
                }
            }

            int result = MaxValue;

            for (int i = 0; i< V; i++)
            {
                for(int j = i; j < V; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    result = Math.Min(result, graph[i, j] + graph[j, i]);
                }
            }

            if (result == MaxValue)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
