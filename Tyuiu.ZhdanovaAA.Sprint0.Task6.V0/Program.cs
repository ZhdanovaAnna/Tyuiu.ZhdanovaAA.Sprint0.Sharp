using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 3, 4, 5, 6, 7 };

            Console.WriteLine("Сумма элементов массива = " + DataServcie.AdditionArray(arraynums));
            Console.WriteLine("Разность элементов массива = " + DataServcie.SubtractionArray(arraynums));
            Console.WriteLine("Произведение элементов массива = " + DataServcie.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}
