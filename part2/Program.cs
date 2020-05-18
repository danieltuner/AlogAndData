using System;
using System.Text;


namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TimeEfficiency timeEfficiency = new TimeEfficiency();

            string input10 = timeEfficiency.CreateInput(10);
            string input100 = timeEfficiency.CreateInput(100);
            string input1000 = timeEfficiency.CreateInput(1000);
            string input10000 = timeEfficiency.CreateInput(10000);
                       
            
            DateTime start = DateTime.Now;
            timeEfficiency.On2(input10);
            DateTime end = DateTime.Now;
            Console.WriteLine("Slow time: " + end.Subtract(start));
            DateTime start2 = DateTime.Now;
            timeEfficiency.On(input10);
    	    DateTime end2 = DateTime.Now;
            Console.WriteLine("Fast time: " + end2.Subtract(start2));*/
            /*
            LongestRepetition p = new LongestRepetition();
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 1, 1, 2 })); // 2
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(p.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 5 */
            
            Changes m = new Changes();
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 2, 2, 2 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 0
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 2            */


        }
    }
}