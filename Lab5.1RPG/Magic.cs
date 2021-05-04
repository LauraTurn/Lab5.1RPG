using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
    public class Magician : GameChar
    {
        private int magicalenergy;

        public int MagicalEnergy { get { return magicalenergy; } set { magicalenergy = value; } }

        public Magician(string name, int intelligence, int strength, int MagicalEnergy) : base(name, intelligence, strength)
        {
            MagicalEnergy = magicalenergy;
        }

        public override void Play()
        {
            //base.Play();
            Console.Write($"{Name}: (int {Intelligence}, strength {Strength}, magic {MagicalEnergy})");
        }
    }
}
