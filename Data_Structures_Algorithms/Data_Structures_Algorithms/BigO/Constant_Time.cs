using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms.BigO
{
    public class Constant_Time
    {
        public static void StartPoint()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("----Constant Time----");
            Console.WriteLine(GetElement(numbers, 4));
        }

        private static int GetElement(int[] arr, int index)
        {
            return arr[index];
        }
    }
}
