using System;
using System.Text;

namespace part2
{

    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int repetition = 1;
            int largest = 1;
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] == t[i-1])
                {
                    repetition++;
                }
                else if (t[i] != t[i-1])
                {
                    repetition = 1;
                }
                if (largest < repetition)
                {
                    largest = repetition;
                }
            }
            return largest;
        }
    }
}