using System;

namespace part3
{
     public class SmallestDifference
    {
        public int Calculate(int[] t)
        {
            Array.Sort(t);
            int diff = int.MaxValue;

            for (int i = 0; i < t.Length - 1; i++)
            {
                if (t[i+1] - t[i] < diff)
                {
                    diff = t[i + 1] - t[i];
                }
            }
            return diff;
        }

        
    }
}