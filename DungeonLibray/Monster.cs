using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibray
{
    public class Monster : Character
    {
        //FIELDS
        private int _minDamage;

        //PROPERTIES
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //Custom business rule -- MinDamage can't exceed MaxDamage & can't be less than 1.
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        //CONSTRUCTOR
        public Monster(string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description)
            : base(name, maxLife, hitChance, block, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        //METHODS
        public override string ToString()
        {
            //return base.ToString();

            return String.Format("\n-=-=-= MONSTER =-=-=-\n" +
                "{0}\n" +
                "Life: {1} of {2}\n" +
                "Damage: {3} - {4}\n" +
                "Block: {5}\n" +
                "Description: \n" +
                "{6}\n",
                Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);

        }
        public override int CalcDamage()
        {
            Random random = new Random();
            int damage = random.Next(MinDamage, MaxDamage + 1);
            return damage;
        }
    }
}
