using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] num_1, int[] num_2)
        {
            int[] resaltArrays = new int[5];
            for (var index = 0; index < resaltArrays.Length; index++)
            {
                resaltArrays[index] = num_1[index] + num_2[index]; 
            }
            return resaltArrays;
        }
    }
}
