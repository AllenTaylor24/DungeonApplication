﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibray
{
    public sealed class Player : Character
    {
        private Race race;
        private Weapon chosenWeapon;

        //FIELDS

        //PROPERTIES
        public Race CharacterRace { get; set; }
        public Weapon EquppiedWeapon { get; set; }
        public int Initiative { get; internal set; }


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
            return $"-=-=-= PLAYER =-=-=-\nName: {Name}\nLife: {Life}-{MaxLife}\nHit Chance: {HitChance}\nBlock: {Block}\nRace: {CharacterRace}\nWeapon Equppied: {EquppiedWeapon}";

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

        //public int CalcAttackBonus()
        //{
        //    int attackBonus = 0;
        //    if (CharacterRace == Race.Cyborg)
        //    {
        //        attackBonus += 10;
        //    }
        //    else if (CharacterRace == Race.Dwarf)
        //    {
        //        attackBonus -= 5;
        //    }
        //    else if (CharacterRace == Race.Werewolf)
        //    {
        //        attackBonus += 5;
        //    }
        //    else if (CharacterRace == Race.Griffin)
        //    {
        //        attackBonus += 15;
        //    }
        //    return attackBonus;
        //}

    }
}
