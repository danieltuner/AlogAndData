using System;
using System.Collections.Generic;

namespace part1
{
  public class Substrings
  {
    public int Calculate(string a, string b)
    {
      int one = a.Length;
      int two = b.Length;
      int result = 0;

      for (int i = 0; i <= one - two; i++)
      {
        int three;
        for (three = 0;three < one; three++)
          if (b[i + three] !=a[three])
          {
            break;
          }
        if (three == one)
        {
          result++;
          three = 0;
        }
        
      }
      return result;
      // how many times is b in a

      /*
      amountOfHits = 0
      for character in a, until a.Length-b.Length
        if character == b index =
          if a in next index == b in next index
            until b ends
            amountOfHits++
      return the amountOfHits
      */
    }
  }
}