using System;
using System.Text;

namespace part2
{

    public class Changes
    {
        public int Calculate(int[] t)
        {
            int change = 0;
            for (int i = 1; i <= t.Length -1; i++)
            {
                if (t[i] == t[i-1])
                {                    
                    change++;
                    if (i < t.Length -1)
                    {
                        t[i] = t[i-1] + t[i + 1] + 1;
                    }
                    else
                    {
                        t[i] = t[i-1] - t[i];
                    }
                }                
            }
            return change;
            
        }
        
            
    }
}