using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
    public class Warrior : GameChar
    {
        private string weapontype;
        public string WeaponType { get { return weapontype; } set { weapontype = value; } }

        public Warrior(string name, int intelligence, int strength, string weapontype) : base(name, intelligence, strength)
        {
            WeaponType = weapontype;
        }

        public override void Play()
        {
            //base.Play();
            Console.Write($"{Name}: ({Intelligence}, {Strength}, {WeaponType}");
        }
    }
}
