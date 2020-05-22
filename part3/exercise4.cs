using System;

namespace part3
{
    public class BinarySearch
    {
        public bool Find(int[] t, int x)
        {
            Array.Sort(t);
            int a = 0;
            int b = t.Length - 1;
            int k;
            while (a <= b)
            {
                k = (a+b) /2;
                
                if (t[k] == x)
                {
                    return true;
                }
                if (t[k] < x)
                {
                    a = k +1;
                }
                if (t[k] > x)
                {
                    b = k - 1;
                }
                
            }
            return false;

        }
        /*
        a = 0
        b = n-1
        while a <= b
        k = (a+b)/2
        if array[k] == x
            // we found the x
            break   
        if array[k] < x
            a = k+1
        if array[k] > x
            b = k-1
            */


    }
}