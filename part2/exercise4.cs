using System;
using System.Text;

namespace part2
{

    public class Revolutions
    {
        public int Calculate(int[] t)
        {       
            int NrOfRuns = 0;
            for (int i = 1; i <= t.Length; i++)
            {
                for (int j = 0; j <= t.Length; j++)
                {
                    if (t[i] == NrOfRuns)
                    {
                        NrOfRuns++;
                    }
                }
            }
            return NrOfRuns;
        }
        
            
    }
}