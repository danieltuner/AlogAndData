using System;
using System.Text;

namespace part2
{

    public class Changes
    {
        public int Calculate(int[] t)
        {
            int sum = 0;
            for (int i = t[0]; i < t.Length -1; i++)
            {
                if (t[i] == t[i-1])
                {
                    sum++;
                }
            }
            return sum;
        }
        
            
    }
}