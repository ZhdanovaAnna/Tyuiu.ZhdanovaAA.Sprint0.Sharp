using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"A + B = {DataService.Addition(34, 65)}");
            Console.WriteLine($"A - B = {DataService.Subtraction(23, 100)}");
            Console.WriteLine($"A * B = {DataService.Multiplication(3, 33)}");
            Console.WriteLine($"A / B = {DataService.Division(23, 0)}");
            Console.ReadKey();
        }
    }
}
