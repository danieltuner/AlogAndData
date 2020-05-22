using System;

namespace part3
{
    public class Inversions
    {
        public int[] Create(int n, int k)
        {
            int k = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for ( int j = 0; j < n; j++)
                {
                    if (n[i] > n[j])
                    {
                        k++;
                    }
                }
            }
            return k;
        }
    }
}