namespace part1
{
  public class Tables
  {
    public int Calculate(int[] t)
    {
      return 0;
    }
  }
}
/*
if t.Length == 1
return the olny item in the table

else 
int[] newArrey = ... int[t.Length -1]
  for each number in t until t.Length-1
    t[i] +t[i+1]
    add the sum to the newArrey
return Calculate(newArrey)
*/