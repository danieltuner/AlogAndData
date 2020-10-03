using System;

namespace Examprep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Numbers num = new Numbers();
            Console.WriteLine(num.Steps(11)); // 5
            Console.WriteLine(num.Steps(150)); // 5
            Console.WriteLine(num.Steps(2)); // 2
        }
    }
}