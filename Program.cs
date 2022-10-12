using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {

        static int health;
        static string status;
        static void Main(string[] args)
        {

            Console.WriteLine("Conditionals");
            Console.WriteLine();

            health = 100;
            TakeDamage(10);
            Console.WriteLine("health: " + health);

            Console.ReadKey(true);

        }

        static void TakeDamage(int damage)
        {
            Console.WriteLine("damage = " + damage);
            health = health - damage;

            status = "";

            if (health == 100)
            {
                status = "Perfect Health";
            }

            if ((health < 100) && (health >= 75))
            {
                status = "Healthy";
            }

            if ((health < 75) && (health >= 50))
            {
                status = "Hurt";
            }

            if ((health < 50) && (health >= 10))
            {
                status = "Badly Hurt";
            }

            if ((health < 10) && (health > 0))
            {
                status = "Imminent Danger";
            }

            if (health <= 0)
            {
                status = "DEAD";
                health = 0;
            }
        }

        static void ShowHud()
        {
            Console.WriteLine("Health: " + health);


            Console.WriteLine("Health Staus: " + status);
        }
    }
}
