using System;

namespace lab_wk05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 20;
            int counter = 0;
            
            while (counter <= N)
            {
                Console.WriteLine(counter);
                counter += 2;
            }
        }
    }
}
