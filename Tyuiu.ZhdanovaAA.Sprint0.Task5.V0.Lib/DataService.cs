using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int num_1, int num_2)
        {
            return num_1 + num_2;
        }

        public static int Subtraction(int num_1, int num_2)
        {
            return num_1 - num_2;
        }

        public static int  Multiplication(int num_1, int num_2)
        {
            return num_1 * num_2;
        }

        public static int Division(int num_1, int num_2)
        {
            if  (num_2 == 0)
            {
                Console.WriteLine("Переменная B = {0}, на ноль делить нельзя");
                return -1;
            }
            else
            {
                return num_1 / num_2;
            }
        }
    }
}
