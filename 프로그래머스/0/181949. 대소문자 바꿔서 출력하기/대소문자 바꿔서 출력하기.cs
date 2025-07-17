using System;

public class Example
{
    public static void Main()
    {
        String s;
        s = Console.ReadLine();
        
        foreach (char ch in s) 
        {
            if (Char.IsLower(ch)) 
            {
                Console.Write(char.ToUpper(ch));            
            }
            else 
            {
                Console.Write(char.ToLower(ch));
            }
        }
    }
}