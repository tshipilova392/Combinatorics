using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subsets
{
    class SubsetsIEnumerable
    {
        static public int[] weights = new int[] { 2, 3, 5 };

        static public void Evaluate(bool[] subset)
        {
            var delta = 0;
            for (int i = 0; i < subset.Length; i++)
                if (subset[i]) delta += weights[i];
                else delta -= weights[i];
            foreach (var e in subset)
                Console.Write(e ? 1 : 0);
            Console.Write(" ");
            if (delta == 0)
                Console.Write("OK");
            Console.WriteLine();
        }

        static public IEnumerable<bool[]> MakeSubsets(bool[] subset, int position)
        {
            if (position == subset.Length)
            {
                yield return subset.ToArray();
                yield break;
            }
            subset[position] = false;
            foreach (var e in MakeSubsets(subset, position + 1))
                yield return e;
            subset[position] = true;
            foreach (var e in MakeSubsets(subset, position + 1))
                yield return e;
        }
    }
}
