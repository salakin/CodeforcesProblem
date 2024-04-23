using System;
 
namespace CodeForeceProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            char[] input1a = s.ToCharArray();
            char[] input2a = t.ToCharArray();
            Array.Reverse(input1a);
             
            if (input1a.SequenceEqual(input2a))
            {
                Console.WriteLine("YES");
            }
            else { Console.WriteLine("NO"); }
 
 
        }
    }
}
