using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.UTs
{
    public class ArrayUtils1
    {
        public static int Sum(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        public static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            Array.Copy(array1, mergedArray, array1.Length);
            Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);
            return mergedArray;
        }
    }

}
