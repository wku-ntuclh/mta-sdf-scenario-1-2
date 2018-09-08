using System;

namespace Scenario_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;

            while(n > 1)
            {
                fact *= n;
                n--;
            }

            Console.WriteLine("fact = {0}", fact);
        }
    }
}
