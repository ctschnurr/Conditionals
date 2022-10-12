using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static string gameName;
        static string studioName;
        static string newFeature;

        static int health;
        static string healthStatus;
        static string weaponName;
        static int weapon;
        static int medPack;

        static ConsoleKeyInfo choice;

        static void Main(string[] args)
        {

            gameName = "STATS TESTER!";
            studioName = "Schnurr Studio!";
            newFeature = "Improved Conditionals!";

            health = 100;
            healthStatus = "Perfect Health";
            weapon = 1;
            weaponName = "Stick";
            medPack = 25;
            
            
            ShowHud();

            while (choice.Key != ConsoleKey.D0)
            {
                ShowHud();
                makeChoice();
            }

            Console.WriteLine("");
            Console.Write("Thank you for playing " + gameName + " By " + studioName);
            Pause();

        }

        static void ChangeWeapon(int weaponPickedUp)
        {
            Console.WriteLine();
            Console.WriteLine("You found a new weapon!");
            Console.WriteLine();

            weapon = weaponPickedUp;

            switch(weapon)
            {
                case 1: 
                    weaponName = "Stick";
                    break;

                case 2:
                    weaponName = "Wooden Sword";
                    break;

                case 3:
                    weaponName = "Iron Sword";
                    break;

                case 4:
                    weaponName = "Steel Sword";
                    break;

                case 5:
                    weaponName = "Enchanted Sword";
                    break;
            }

        }
        static void HealthStat()
        {
            healthStatus = "";

            if (health == 100)
            {
                healthStatus = "Perfect Health";
            }

            if ((health < 100) && (health >= 75))
            {
                healthStatus = "Healthy";
            }

            if ((health < 75) && (health >= 50))
            {
                healthStatus = "Hurt";
            }

            if ((health < 50) && (health >= 10))
            {
                healthStatus = "Badly Hurt";
            }

            if ((health < 10) && (health > 0))
            {
                healthStatus = "Imminent Danger";
            }

            if (health <= 0)
            {
                healthStatus = "DEAD";
                
            }
        }

        static void ShowHud()
        {
            //            Console.WriteLine("Health: " + health);
            //            Console.WriteLine("Health Staus: " + status);

            string hudHealth = health.ToString();


            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  Welcome to " + gameName + " Now with " + newFeature.PadRight(38) + "By " + studioName);
            Console.WriteLine(".------------------------------------------------------------------------------------------.");
            Console.WriteLine("|    Health: " + health + "/ 100         Status: " + healthStatus.PadRight(17) + "  |     Weapon: " + weaponName.PadRight(20) + "|");
            Console.WriteLine("'------------------------------------------------------------------------------------------'");
            Console.WriteLine("");

        }

        static void makeChoice()
        {
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("");
            Console.WriteLine("  1 - Find a new random weapon");
            Console.WriteLine("  2 - Simulate battle damage");
            Console.WriteLine("  3 - Add Health");
            Console.WriteLine("  0 - Exit");
            Console.WriteLine("");
            Console.Write("Enter Choice: ");

            choice = Console.ReadKey(true);
            Console.WriteLine("");

            if (choice.Key == ConsoleKey.D1)
            {
                
                Random rand = new Random();
                int randomPickup = rand.Next(1, 6);

                ChangeWeapon(randomPickup);

                Console.WriteLine("You picked up a " + weaponName + "!");
                Pause();
             
             }

            if (choice.Key == ConsoleKey.D2)
            {
                Random rand = new Random();
                int potentialHarm = rand.Next(0, 100);
                TakeDamage(potentialHarm);
            }

            if (choice.Key == ConsoleKey.D3)
            {
                Heal();
            }
        }

        static void Pause()
        {
            Console.ReadKey(true);
            Console.WriteLine("");
        }

        static void TakeDamage(int damage)
        {
            if (health == 0)
            {
                Console.WriteLine("");
                Console.Write("The player is dead!");
                Pause();

            }

            else
            {
                
                health = health - damage;
                Console.WriteLine("");
                Console.Write("Player took " + damage + " damage!");
                HealthStat();

                if (health < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Player has ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("DIED");
                    Console.ResetColor();
                    Console.WriteLine("!");
                    health = 0;
                                       
                }

                Pause();
            }
        }

        static void Heal()
        {
            health = health + medPack;

            Console.WriteLine("");
            Console.WriteLine("Player received a +" + medPack + " health pack!");

            if (health > 100)
            {
                Console.WriteLine("Player is fully healed!");
                health = 100;
            }

            HealthStat();
                        
            Pause();
            
        }

    }
}
