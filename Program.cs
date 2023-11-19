using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());
            double f = 1.8 * c + 32;
            Console.WriteLine(Math.Round(f, 2));

        }
    }
}
