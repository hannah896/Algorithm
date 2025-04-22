using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class3
    {
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list_Card = new List<int>();
            List<int> Card_list = new List<int>();

            Dictionary<int, int> dict  = new Dictionary<int, int>(); 
            
            string[] arrs = Console.ReadLine().Split(' ');
            
            foreach(string arr in arrs)
            {
                list_Card.Add(int.Parse(arr));
            }

            foreach(int Card in list_Card)
            {
                //이미 등록된 카드라면
                if (!dict.TryGetValue(Card, out int value))
                {
                    dict.Add(Card, 1);
                }
                //최초카드
                else
                {
                    dict[Card] = dict[Card] + 1;
                }
            }

            int M = int.Parse(Console.ReadLine());

            string[] array = Console.ReadLine().Split(' ');

            foreach (string arr in array)
            {
                Card_list.Add(int.Parse(arr));
            }

            foreach (int num in Card_list)
            {
                //이미 등록된 카드라면
                if (!dict.TryGetValue(num, out int value))
                {
                    sb.Append(0 + " ");
                }
                //최초카드
                else
                {
                    sb.Append(value + " ");
                }
            }

            Console.Write(sb.ToString());
        }
    }
}
