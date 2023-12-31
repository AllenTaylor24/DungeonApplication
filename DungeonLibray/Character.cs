﻿namespace DungeonLibray
{
    //The "abstract" modidifer
    //Denotes this datatype class is "incompleete" -- we don't intend to have 
    //"Characters", and we instead only awantt the more specific child classes
    //in our game (Player & MOnster). Abstracct maes vit so we cannotcreate
    //just a Character -- it must be more sepcifc
    public abstract class Character
    {
        /*
          * Creates Fields and Properties for each of the followin attributes.
          * life – int
            name – string
            hitChance – int
            block – int
            maxLife – int
          
            INCLUDE a business rule that Life cannot be more than MaxLife. If it is, set it equal to MaxLife.
          
          */
        //FIELDS
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;

        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= _maxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = _maxLife;
                }
            }
        }


        //CONSTRUCTORS 
        public Character(string name, int maxLife, int hitChance, int block, int life)
        {
            MaxLife = maxLife;
            Life = life;
            Name = name;
            HitChance = hitChance;
            Block = block;
            
        }
        public virtual int CalcBlock()
        {
            return _block;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }

        //METHODS
        public override string ToString()
        {
            return $"Name: {Name}, Life: {Life}, Hit Chance: {HitChance}, Block: {Block}, Max Life: {MaxLife}";
        }



    }
}