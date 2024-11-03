using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms.BigO
{
    public class Linear_Time
    {
        private static string[] animeCharacters = { "Naruto", "Sakura", "Sasuke", "Luffy", "Goku", "Levi" };
        public static void StartPoint()
        {
            Console.WriteLine("----Linear Time----");
            SearchForCharacter("Naruto");
        }
        private static void SearchForCharacter_Old(string character)
        {
            for (int i = 0; i < animeCharacters.Length; i++)
            {
                if (animeCharacters[i] == character)
                {
                    Console.WriteLine($"Found {character}");
                }
            }

            // O(n)
        }
        private static void SearchForCharacter(string character)
        {
            for (int i = 0; i < animeCharacters.Length; i++)
            {
                if (animeCharacters[i] == character)
                {
                    Console.WriteLine($"Found {character}");
                }
            }

            for (int j = 0; j < animeCharacters.Length; j++)
            {
                if (animeCharacters[j] == character)
                {
                    Console.WriteLine($"Found {character} 2");
                }
            }

            // n + n = 2n -> O(2n)
            // Drop the constant so it becomes O(n)
        }
    }
}
