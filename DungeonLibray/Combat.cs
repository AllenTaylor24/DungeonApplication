using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibray
{
    public class Combat
    {
        //THis is NOT intended to be a datatype class, so it will not 
        //have fields, properties, or constructors. It will simpy serve.
        //as a "warehouse" for a variety of methods related to combat.

        //Let's crate a method to handle a one-sided attack
        public static void DoAttack(Character attacker, Character defender)
        {
            //Get a random number from 1-100
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            //Nothing is TRULY random in programming.
            //our Random.Next() relies upon the time it is executed to influence
            //the outcome. So, we can pause code execution briefly to hlep
            //simulate the feeling of more random results. We can use
            //System.Threading.Thread.Sleep() for this.

            System.Threading.Thread.Sleep(30); //The number of milliseconds to pause code execution

            //IF the attacker "hits"
            if(roll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //Calculate the damage
                int damageDealt = attacker.CalcDamage();

                //Substact & assign the damage to the defender's life
                defender.Life -= damageDealt;

                //Output the result
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} striked {1} for {2} damage!",
                    attacker.Name, defender.Name, damageDealt);

                //Reset the color so our text returns to normal
                Console.ResetColor();

            }
            //If the attacker "missess"
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }
        }

        //Now, we can create a method to handle "battle" -- attacks from both sides
        public static void DoBattle(Player player, Monster monster)
        {
            #region Customization Option - Initiative
            //Consider adding an Initiative property to Charactter, then
            //check the Initivative of the Player & Monste to determine who attacks first
            if (player.Initiative >= monster.Initiative)
            {
                DoAttack(player, monster);
            }
            else
            {
                  DoAttack(monster, player);
            }


            #endregion

            //For our example, we'll grant the Player "initiative" by default
            DoAttack(player, monster);

            //If the Monster survives, they get to attack the player back
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }

    }
}
