using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, r;
            Console.Write("Enter X = ");
            x = Correct();
            Console.WriteLine("////////////////");
            Console.Write("Enter Y = ");
            y = Correct();
            Console.WriteLine("////////////////");
            Console.Write("Enter Z = ");
            z = Correct();
            Console.WriteLine("////////////////");
            r = ((2 * Math.Cos(x * x) - (1 / 2)) / ((1 / 2) + Math.Sin(Math.Pow(y, 2 - z)))) + ((z * z) / (7 - (z / 3)));
            Console.WriteLine($"r = {r}");
        }
        public static double Correct()
        {
            var a = Console.ReadLine();
            double x;
            if(!Double.TryParse(a,out x))
            {
                Console.WriteLine("Enter new number!");
                a = Console.ReadLine();
                
            }return x;
        }
    }
}
