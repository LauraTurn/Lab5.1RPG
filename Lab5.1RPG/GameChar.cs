using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab5._1RPG
{
    public class GameChar
    {
        private string name;
        private int strength;
        private int intelligence;

        public string Name { get { return name; } set { name = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }
        public int Strength { get { return strength; } set { strength = value; } }

        public GameChar (string name, int intelligence, int strength)
        {
            Name = name;
            Intelligence = intelligence;
            Strength = strength;            
        }

        public virtual void Play()
        {
            Console.Write($"{Name}: (int {Intelligence}, strength {Strength})");
        }

    }
}
