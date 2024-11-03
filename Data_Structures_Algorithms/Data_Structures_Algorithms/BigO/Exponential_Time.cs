using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms.BigO
{
    public class Exponential_Time
    {
        public static void StartPoint()
        {
            Console.WriteLine("----Exponential Time----"); 
            int number = 45;
            Console.WriteLine($"Fibonacci of {number} is {Fibonacci(number)}");
        }
        private static int Fibonacci(int number)
        {
            if (number <= 1) return number;
            return Fibonacci(number - 1) + Fibonacci(number - 2); // Recursive calls lead to exponential growth
        }
    }
}
