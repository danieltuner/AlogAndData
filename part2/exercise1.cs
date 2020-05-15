using System;
using System.Text;

namespace part2
{

    public class TimeEfficiency
    {
        public void On2(string n)
        {
            int counter = 0;
            for (int i = 0; i <= n.Length; i++)
            {
                for (int j = i + 1; j <= n.Length -1; j++)
                {
                    if (n[i].ToString() == "0" && n[j].ToString() == "1")
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine("Hits: " + counter);   
        }
        public void On(string n)
        {
            int counter = 0;
            int zeros = 0;
            for (int i = 0; i <= n.Length - 1; i++)
            {
                if (n[i].ToString() == "0")
                {
                    zeros = zeros + 1;
                }
                else
                {
                    counter = counter + zeros;
                }
            }
            Console.WriteLine("Hits: " + counter);

        }
        public string CreateInput(int n)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                sb.Append(random.Next(0, 2).ToString());
            }
            return sb.ToString();
        }
    }
}
