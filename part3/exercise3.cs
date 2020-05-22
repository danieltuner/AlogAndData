using System;

namespace part3
{
    public class Sorting
    {
        public void MergeSort(int[] t)
        {
            int 



/*sort(a,b)
  if a == b
    return
  k = (a+b)/2
  sort(a,k)
  sort(k+1,b)
  merge(a,k,k+1,b)
  */
        }

        public void QuickSort(int[] t)
        {
            int high, low;
            int pivot = t[high];
            for (int j = low; j < high; j++)
            {
                if (t[j] < pivot)
                {
                    i++;
                    int temp = t[i];
                    t[i] = t[j];
                    t[j] = temp;
                }
            }
            int temp1 = t[i+1];
            t[i+1] = t[high];
            t[high] = temp1;

            return i +1;


/*
sort(a, b)
  if a >= b
    return
  k = pivot(a,b)
  sort(a, k-1)
  sort(k+1, b)
*/
        }

        


    }
}