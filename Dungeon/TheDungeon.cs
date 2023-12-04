using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonLibray;


namespace DungeonApplication
{
    class TheDungeon
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
            Weapon w1 = new Weapon("The Dragon Slayer", 35, 20, 10, true, WeaponType.Sword);
            Weapon w2 = new Weapon("Nerf Gun", 25, 15, 5, false, WeaponType.Projectile);
            Weapon w3 = new Weapon("Bloody Dagger", 15, 10, 5, false, WeaponType.Knife);

            //Console.WriteLine(w1);

            #endregion
            #region Cumstomization Option - Player Customization

            //Alow the player to choose certain aspects of their charcater.
            Console.Write("Pleaser enter your name: ");
            string playerName = Console.ReadLine();
            #endregion

            #region Player Object Creation

            Player player = new Player(playerName, 150, 35, 15, 115, Race.Werewolf, w2);
            //Player player2 = new Player("Guts", 200, 50, 25, 200, Race.Human, w1);

            //Console.WriteLine(p1);
            #endregion

            #region Main Game Loop

            bool exit = false;

            do
            {
                #region Monster Object Creation

                Demogorgon demogorgon = new Demogorgon("Slimy Demogorgon", 250, 30, 50, 250, 50, 30, "That is a slimy monster!", true);
                Demogorgon demogorgon2 = new Demogorgon("Demogorgon", 200, 25, 30, 150, 30, 25, "That is a nasty looking monster!", false);

                Griffin griffin = new Griffin("Griffin", 150, 20, 30, 120, 30, 10, "...", 10, 30);
                Griffin griffin2 = new Griffin("Two-Headed Griffin", 200, 25, 30, 120, 25, 10, "....", 15, 35);

                Vampire vampire = new Vampire("Dracula", 100, 25, 15, 100, 25, 15, "A blood-sucking fiend.");

                Monster[] monsters = { demogorgon, demogorgon2, griffin, griffin2, vampire , vampire};

                Random randMonster = new Random();

                int randNbr = randMonster.Next(monsters.Length);

                Monster chosenMonster = monsters[randNbr];


                #endregion

                #region Room Creation

                Console.WriteLine(GetRoom());

                Console.Write("\nIn this room, you see a " + chosenMonster.Name + "!");

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

                            #region Customization Option - Racial/Weapon Bonus

                            //You could consider giving bonuses based on the player's race,
                            //weapon, the monster they are facing, etc.

                            //if (player.CharacterRace == Race.Griffin)
                            //{
                            //    Combat.DoAttack(player, chosenMonster);
                            //}
                            //if (player.EquppiedWeapon.Name == "The Dragon Slayer" && chosenMonster.GetType().ToString() == "Dragon")
                            //{
                            //    Combat.DoAttack(player, chosenMonster);
                            //}
                            #endregion

                            //Execute Combat
                            Combat.DoBattle(player, chosenMonster);

                            //Check if the monster is dead
                            if (chosenMonster.Life <= 0)
                            {
                                #region Customization Option - Combat Rewards

                                //You could add some logic here to grant the Player life:
                                //player.Life += 5;

                                //Or, loot drops! (Note: This would require an Item class, 
                                //as well as a property for the player of type List<Item>):


                                //Item rubyNecklace = new Item("Ruby Necklace", "Increases Max Life", MaxLife, 10);
                                //player.Inventory.Add(rubyNecklace);
                                //Console.WriteLine($"{player.Name} received {rubyNecklace.Name}!");
                                //Console.WriteLine($"{rubyNecklace}");


                                #endregion

                                //Use green text to highlight winning combat
                                Console.ForegroundColor = ConsoleColor.Green;

                                //Out the resutls
                                Console.WriteLine("\nYou killed {0}!\n", chosenMonster.Name);

                                //Reset the color
                                Console.ResetColor();

                                //Update the score
                                score++;

                                //Flip the reload bool to exit the menu loop and get a new room & new moster
                                reload = true;
                            }

                            break;

                        case ConsoleKey.R:
                            Console.WriteLine("{0} chooses to run away!", player.Name);

                            //The mosnter gets an attack of opportunity
                            Console.WriteLine($"{chosenMonster.Name} attacks {player.Name} as they flee!");

                            Combat.DoAttack(chosenMonster, player);

                            //Blank line for formatting
                            Console.WriteLine();

                            //Since the player has fled the room, we will need to reload
                            reload = true;
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine(chosenMonster);
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
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("You have been vanquished.");
                        exit = true;
                    }



        
                    #endregion

                    #endregion

                } while (!exit && !reload);

                #endregion

            } while (!exit);//While exit is NOT true, keep looping

            #endregion

            #region Output Final Score / End the Game

            //TODO Output Final Score & End the Game
            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? ".": "s."));

            #endregion

        }

        #region Create GetRoom() Functionality

        public static string GetRoom()
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
