using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibray
{
    public class Demogorgon : Monster
    {
        public bool IsSlimy { get; set; }

        public Demogorgon(string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description,
            bool isSlimy): base (name , maxLife, hitChance, block, life, maxDamage, minDamage, description)
        {
            IsSlimy = isSlimy;
        }
        public override string ToString()
        {
            return base.ToString() + (IsSlimy ? "Slimy" : "Not so slimy");
        }
        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsSlimy)
            {
                calculatedBlock += (calculatedBlock / 2);
            }
            return calculatedBlock;
        }
    }
}
