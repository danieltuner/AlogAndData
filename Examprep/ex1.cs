using System;

namespace Examprep
{
    public class Numbers
    {
        public int Steps(int x)
        {
            int count = 0;
            int  i = 1;
            int sum = 0;

            while (sum < x)
            {
                sum += i;
                count++;
                i++;
            }
            return count;
        }
  
    }
}