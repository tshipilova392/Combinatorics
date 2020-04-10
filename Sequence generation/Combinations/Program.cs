using System;
using System.Collections.Generic;

namespace Combinations
{
    class Program
    {
        static public IEnumerable<bool[]> MakeCombinations(bool[] combination, int elementsLeft, int position)
        {
            if (elementsLeft == 0)
            {
                yield return combination;
                yield break;
            }
            if (position == combination.Length)
                yield break;

            combination[position] = true;
            foreach (var e in MakeCombinations(combination, elementsLeft - 1, position + 1))
                yield return e;
            combination[position] = false;
            foreach (var e in MakeCombinations(combination, elementsLeft, position + 1))
                yield return e;
        }

        static void Main(string[] args)
        {
            var combinations = MakeCombinations(new bool[5], 3, 0);

            foreach (var combination in combinations)
            {
                foreach (var e in combination)
                    Console.Write(e ? 1 : 0);
                Console.WriteLine();
            }
        }
    }
}
