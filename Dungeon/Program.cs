using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonLibray;


namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction

            Console.Title = "DUNGEON OF DOOM";

            Console.WriteLine("Your adventure begins...\n");

            #endregion

            #region Variable to Keep Score

            int score = 0;

            #endregion

            #region Weapon Object Creation

            //TODO Create a Weapon
            Weapon w1 = new Weapon("Dragon Slayer", 45, 5, 15, true);

            // Console.WriteLine($"\nWeapon Name:{w1.Name}\nDamage:{w1.MaxDamage}-{w1.MinDamage}\nBonus Hit Chance: {w1.BonusHitChance}%\n" +
            //   $"Handedness: {w1.IsTwoHanded}");
            Console.WriteLine(w1);

            #endregion

            #region Player Object Creation

            //TODO Create a Player (and equip them with a weapon)
            Character c1 = new Character("John Marston", 100, 25, 15, 75);

            //Console.WriteLine($"Name: {c1.Name}\nMax: Life: {c1.MaxLife}\nHit Chance: {c1.HitChance}\nBlock: {c1.Block}" +
            //  $"\nMax Life: {c1.Life}\n");
            Console.WriteLine(c1);
            #endregion

            #region Main Game Loop

            bool exit = false;

            do
            {
                #region Monster Object Creation

                //TODO Create a Monster

                #endregion

                #region Room Creation

                //TODO Create a room (GetRoom())
                Console.WriteLine(GetRoom());

                #endregion

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {
                    #region Display the Menu

                    //Display the menu
                    Console.WriteLine("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    //Capture the user's menu selection
                    ConsoleKey userChoice = Console.ReadKey(true).Key;//Executes upon input, without hitting enter

                    //Clear the console
                    Console.Clear();

                    //Use branching logic to act upon the user's selection
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO Add Combat functionality
                            Console.WriteLine("Attack");
                            break;

                        case ConsoleKey.R:
                            //TODO Run Away
                            Console.WriteLine("Run Away");
                            break;

                        case ConsoleKey.P:
                            //TODO Display Player Info
                            Console.WriteLine("Player Info");
                            break;

                        case ConsoleKey.M:
                            //TODO Display Monster Info
                            Console.WriteLine("Monster Info");
                            break;

                        case ConsoleKey.X:
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an option most improper. Triest thou again.");
                            break;
                    }

                    #region Check Player Life

                    //TODO Check Player Life

                    #endregion

                    #endregion

                } while (!exit && !reload);

                #endregion

            } while (!exit);//While exit is NOT true, keep looping

            #endregion

            #region Output Final Score / End the Game

            //TODO Output Final Score & End the Game

            #endregion

        }

        #region Create GetRoom() Functionality

        //Create GetRoom()
        private static string GetRoom()
        {
            string[] rooms = { 
                "Imagine stepping into a room shrouded in darkness. The walls are adorned with ancient, cobweb-covered paintings that seem to follow your every move.",
                "Imagine stepping into a cozy room with soft lighting, comfy furniture, and beautiful artwork. It's a perfecft space to relax and unwind, surrounded by a warm and inviting atmosphere.",
                "Picture stepping into a dimly lit room, with flickering candles casting eerie shadows on the walls. The air feels heavy, and you can hear faint whispers echoing in the distance. ",
                "Imagine stepping into a room that seems frozen in time. The walls are peeling wallpaper, revealing glimpses of faded portraits. The floor creaks under your every step, as if it's whispering secerts."
            };

            Random random = new Random(); 
            int index = random.Next(rooms.Length);
            return rooms[index];  
        }



        #endregion
    }
}
