using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Метод сложения: {DataService.Addition(38, 45)}");
            Console.WriteLine($"Метод вычитания: {DataService.Subtraction(38, 45)}");
            Console.WriteLine($"Метод умножения: {DataService.Multiplication(24, 4)}");
            Console.WriteLine($"Метод деления: {DataService.Division(55, 5)}");
            Console.ReadKey();
        }
    }
}
