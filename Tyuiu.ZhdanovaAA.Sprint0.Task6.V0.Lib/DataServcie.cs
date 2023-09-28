using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task6.V0.Lib
{
    public class DataServcie
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var index = 0; index < numbers.Length; index++)
            {
                total += numbers[index];
            }
            return total;
        }

        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total -= numbers[index];
                index++;
            }
            return total;

        }

        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total *= numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;
        }
    }
}
