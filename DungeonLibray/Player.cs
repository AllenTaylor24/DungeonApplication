using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibray
{
    public class Player : Character
    {
        //FIELDS

        //PROPERTIES
        public Race CharacterRace { get; set; }
        public Weapon EquppiedWeapon { get; set; }

        //CONSTRUCTORS
        public Player(string name, int maxLife, int hitChance, int block, int life, Race characterRace, Weapon equppiedWeapon)
           : base(name, life, hitChance, block, maxLife)
        {
            CharacterRace = characterRace;
            EquppiedWeapon = equppiedWeapon;
        }

        //METHODS

        public override string ToString()
        {
            //return base.ToString();
            return $"-=-=-= PLAYER =-=-=-\nName: {Name}\nMax Life: {MaxLife}\nHit Chance: {HitChance}\nBlock: {Block}\nLife:{Life}\nRace: {CharacterRace}" +
                $"\nWeapon Euppied: {EquppiedWeapon}";

        }

        public override int CalcDamage()
        {
            Random random = new Random();
            int damage = random.Next(EquppiedWeapon.MinDamage, EquppiedWeapon.MaxDamage + 1);
            return damage;
        }
        public override int CalcHitChance()
        {

            return base.CalcHitChance() + EquppiedWeapon.BonusHitChance;
        }



    }
}
