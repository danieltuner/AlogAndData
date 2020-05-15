using System;
using System.Text;

namespace part2
{

    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int repetition = 1;
            for (int i = t[0]; i < t.Length -1; i++)
            {
                if (t[i] == t[i-1])
                {
                    repetition++;
                }
            }
            return repetition;
        }
    }
}