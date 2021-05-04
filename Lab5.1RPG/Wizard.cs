using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
    public class Wizard : Magician
    {
        private int spellnumber;
        public int SpellNumber { get { return spellnumber; } set { spellnumber = value; } }

        public Wizard(string name, int intelligence, int strength, int MagicalEnergy, int SpellNumber) : base (name, intelligence, strength, MagicalEnergy)
        {
            SpellNumber = spellnumber;
        }

        public override void Play()
        {
            //base.Play();
            Console.WriteLine($"{Name}: (int {Intelligence}, strength {Strength}, magic {MagicalEnergy}), {SpellNumber} spells");
        }
    }
}
