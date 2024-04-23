using System;
 
namespace CodeForeceProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
 
            int countup = 0, countlow = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    countup++;
                }
                else
                {
                    countlow++;
                }
            }
            if (countup > countlow)
            {
                char ch;
                for (int i = 0; i < s.Length; i++)
                {
                    ch = Char.ToUpper(s[i]);
                    Console.Write(ch); 
                }
            }
            else
            {
                char ch;
                for (int i = 0; i < s.Length; i++)
                {
                    ch = Char.ToLower(s[i]);
                    Console.Write(ch); 
                }
            }
        }
    }
}
