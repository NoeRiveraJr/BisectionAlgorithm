using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11};
            BisectionAlgorithm bisection = new BisectionAlgorithm();
            Console.WriteLine("Pick a number from 1 - 10 to see how long it takes the computer to guess that number!");
            int check = Int32.Parse(Console.ReadLine());
            Tuple<Array, string> bisect = (bisection.performBisection(list, check));
            Console.WriteLine(bisect.Item2);
            foreach(int x in bisect.Item1)
            {
                Console.WriteLine(x);
            }
        }
    }
}
