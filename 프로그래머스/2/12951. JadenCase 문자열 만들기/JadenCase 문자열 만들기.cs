using System.Globalization;
using System.Text;

public class Solution
{
    private StringBuilder sb = new StringBuilder();

    public string solution(string s)
    {
        s = s.ToLower();

        bool isEmpty = true;

        foreach (char c in s)
        {
            if (isEmpty)
            {
                sb.Append(char.ToUpper(c));
                isEmpty = false;
            }
            else
            {
                sb.Append(c);
            }
            if (c.Equals(' '))
            {
                isEmpty = true;
            }
        }
        return sb.ToString();
    }
}