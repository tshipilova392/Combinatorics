using System;
using System.Collections.Generic;

namespace Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
            Subsets.MakeSubsets(new bool[Subsets.weights.Length], 0);
            Console.WriteLine();

            var subsets = SubsetsIEnumerable.MakeSubsets(new bool[SubsetsIEnumerable.weights.Length], 0);
            foreach (var subset in subsets)
            {
                foreach (var e in subset)
                    Console.Write(e ? 1 : 0);
                Console.WriteLine();
            }

            foreach (var subset in subsets)
            {
                SubsetsIEnumerable.Evaluate(subset);
            }
        }
    }
}
