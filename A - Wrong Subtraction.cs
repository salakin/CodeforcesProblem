using System;
 
namespace CodeForeceProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
 
            int r;
            int n = int.Parse(input[0]);
            int a = int.Parse(input[1]); 
            for (int i = 1; i <= a; i++)
            {
                r = n % 10;
                if (r == 0)
                {
                    n /= 10;
                }
                else
                    n -= 1;
            }
            Console.WriteLine(n); 
        }
    }
}
