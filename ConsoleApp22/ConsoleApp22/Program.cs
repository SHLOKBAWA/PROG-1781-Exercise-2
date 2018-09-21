using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 30, y = 80, z = 90;
            double sum = x + y + z;
            double average = sum / 3;
            Console.WriteLine("Average of " + x+" , " + y+" and " + z +" is " + average);
        }
    }
}
