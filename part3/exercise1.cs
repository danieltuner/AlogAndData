using System;

namespace part3
{
     public class Hello
    {
        public int Hello(int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Hello!");
                Hello(n-1);
            }
        }        
    }
}
/* void Hello(n)
  if n == 0
    return
  else
    print("Hello!")
    Hello(n-1)
    */