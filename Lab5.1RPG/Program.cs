using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5._1RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World of Dev.Buildcraft!\n");

            List<GameChar> gameCharacters = new List<GameChar>();
            GameChar first = new Warrior("Tharg the Barbarian", 9, 16, "Axe");
            GameChar second = new Warrior("Kincaid the Fighter", 16, 15, "Longsword");
            GameChar third = new Warrior("Grand the Viking", 16, 15, "Spear");
            GameChar fourth = new Wizard("Lady Witherell the Wizard", 18, 11, 10, 5);
            GameChar fifth = new Wizard("Pearl the Magician", 17, 12, 9, 4);

            gameCharacters.Add(first);
            gameCharacters.Add(second);
            gameCharacters.Add(third);
            gameCharacters.Add(fourth);
            gameCharacters.Add(fifth);

            for (int i = 0; i < gameCharacters.Count; i++)
            {
                Console.WriteLine();
                gameCharacters[i].Play();
            }


        }
    }
}
