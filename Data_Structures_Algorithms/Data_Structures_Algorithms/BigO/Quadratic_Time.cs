using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms.BigO
{
    public class Quadratic_Time
    {
        public static void StartPoint()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("----Quadratic Time----");
            PrintPairs(arr);
        }

        private static void PrintPairs(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    Console.WriteLine($"Pair: {arr[i]}, {arr[j]}"); // Nested loop creates quadratic time complexity
                }
            }
        }
        // Complexity analysis
        // O(n^2) is the dominant term
        // O(n) is the non-dominant term
        // Therefore, the overall complexity simplifies to O(n^2)
    }
}
