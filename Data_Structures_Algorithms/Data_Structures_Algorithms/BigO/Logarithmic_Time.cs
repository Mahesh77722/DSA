using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms.BigO
{
    public class Logarithmic_Time
    {
        public static void StartPoint()
        {
            int number = 10000000;         
            Console.WriteLine("----Logarithmic Time----");
            Console.WriteLine($"Number of digits in {number} is {CountDigits(number)}");
        }

        private static int CountDigits(int number)
        {
            int count = 0;

            while (number > 0)
            {
                number /= 10; 
                count++;
            }

            return count; 
        }
    }
}
