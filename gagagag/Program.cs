using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gagagag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number N:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Need positive number");
            }
            else
            {
                int b = 0;
                for (int i = 1; i <= n; i++)
                {
                    b += i;
                }
                Console.WriteLine($"Amount from 1 to {n} = {b}");
            }
        }
    }
}
// И что с ним не так?
