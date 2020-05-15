using System;
using System.Text;


namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeEfficiency timeEfficiency = new TimeEfficiency();

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
            Console.WriteLine("Fast time: " + end2.Subtract(start2));
        }
    }
}