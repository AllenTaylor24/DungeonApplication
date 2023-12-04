using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibray
{
    public class Griffin : Monster
    {
        public int BonusBlock { get; set; }

        public int FlyPrecent { get; set; }

        public Griffin(string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description, int bonusBLock, int flyPrecent) : base (name, maxLife, hitChance, block, life, maxDamage, minDamage, description)
        {
            BonusBlock = bonusBLock;
            FlyPrecent = flyPrecent;
        }
        public override string ToString()
        {
            //return base.ToString();

            return String.Format("{0}\n{1}% chance it will fly way, granting {2} bounus block.",
                base.ToString(), FlyPrecent, BonusBlock);
        }
        public override int CalcBlock()
        {
            // return base.CalcBlock();
            int calculateBlock = Block;
            Random random = new Random();
            int percent = random.Next(101);

            //Cehck if percent is less than or equal to fly perent

            if (percent <=FlyPrecent)
            {
                calculateBlock += BonusBlock;
            }
            return calculateBlock;
        }
    }
}
