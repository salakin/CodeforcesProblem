using System;
 
namespace CodeForeceProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
             
            long sum = 0;
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int w = int.Parse(input[2]);     
            for (int i = 1; i <= w; i++)
            {
                sum = sum + (i * k);
            }
            if (sum <= n)
            {
                Console.WriteLine(0); 
            }
            else Console.WriteLine(sum - n);
        }
    }
}
