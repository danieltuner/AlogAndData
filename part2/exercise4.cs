using System;
using System.Text;

namespace part2
{

    public class Revolutions
    {
        public int Calculate(int[] t)
        {       
           int rev = 0;
            int search = 1;

            while (true)
            {
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] == search)
                    {
                        search++;
                    }

                }
                rev++;
                if (search > t.Length)
                {
                    break;
                }
            }
            return rev;
           
            /*int NrOfRuns = 0;
            int counter = 1;
            for (int i = 1; i <= t.Length; i++)
            {
                for (int j = 0; j <= t.Length -1; j++)
                {
                    if (t[j] == counter)
                    {
                        counter++;
                        if (counter == t.Length +1)
                        {
                            NrOfRuns = i;
                        }
                    }
                }
            }
            return NrOfRuns;*/
        }
        
            
    }
}