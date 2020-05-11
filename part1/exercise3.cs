using System;

namespace part1
{
  public class Tables
  {
    public int Calculate(int[] t)
    {
      if (t.Length == 1)
      {
        return t[0];
      }
      else
      {
        int[] newArray = new int [t.Length -1];
        {        
          for (int i = 0; i < t.Length - 1; i++)
          {
            newArray[i] = t[i] + t[i + 1];
          }
        }
      }
      return Calculate(newArrey);
    }
  }
}
/*
if t.Length == 1
return the only item in the table

else 
int[] newArray = ... int[t.Length -1]
  for each number in t until t.Length-1
    t[i] +t[i+1]
    add the sum to the newArrey
return Calculate(newArray)
*/