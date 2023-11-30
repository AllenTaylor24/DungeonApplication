using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibray;

namespace DungeonLibray
{
    public class Weapon
    {
        //Fields
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;


        
        //Properties
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }

        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value >0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        public WeaponType Type { get; set; }
        //Constructors
        public Weapon (string name, int maxDamage, int minDamage, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }
        //Methods
        public override string ToString()
        {
            string handedness = IsTwoHanded ? "Two-Handed" : "One-Handed";
            return $"Name:{Name}, Damage:{MinDamage}-{MaxDamage}, Bonus Hit Chance: {BonusHitChance} " +
                $"Handedness: {handedness}  Weapon Type: {Type}";
        }


    }

}
