using System;
using System.Collections.Generic;

namespace ReducedIDNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = int.Parse(Console.ReadLine());
            int m = g;
            int[] inputs = new int[g];

            for (int i = 0;  i < g; i++)
            {
                inputs[i] = int.Parse(Console.ReadLine());
            }

            HashSet<int> reducedIDs = new HashSet<int>();

            while (true)
            {
                for (int i = 0; i < g; i++)
                {
                    reducedIDs.Add(inputs[i] % m);
                }
                if (reducedIDs.Count == g)
                {
                    Console.WriteLine(m);
                    break;
                }
                else
                {
                    m++;
                    reducedIDs.Clear();
                }

            }
        }
    }
}
