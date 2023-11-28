using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            #endregion

            #region Player Object Creation

            //TODO Create a Player (and equip them with a weapon)

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

        #endregion
    }
}
