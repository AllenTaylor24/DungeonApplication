using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibray
{
    public class KingKong : Monster
    {
        public bool IsMad { get; set; }
        public KingKong(string name, int maxLife, int hitChance, int block, int life, int maxDamage, int minDamage, string description, bool isMad) : base(name, maxLife, hitChance, block, life, maxDamage, minDamage, description)
        {
            IsMad = isMad;
        }
        
        public override string ToString()
        {
            return base.ToString() + (IsMad ? "Mad" : "Not very mad."); 
            
        }
        public override int CalcDamage()
        {
            int cacluclatedDamage = MaxDamage;
            if (IsMad)
            {
                cacluclatedDamage += 25;
            }
            return cacluclatedDamage;
        }

    }
}
