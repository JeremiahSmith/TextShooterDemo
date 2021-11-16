using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Build Game Objects
            Gun glock = new Gun() { GunName = "Glock", AmmoLoaded = 12, AmmoMax = 12, damage = 4 };
            Gun mouser = new Gun() { GunName = "Mouser", AmmoLoaded = 15, AmmoMax = 15, damage = 3 };
            Gun bazuka = new Gun() { GunName = "Bazuka", AmmoLoaded = 2, AmmoMax = 2, damage = 5 };
            Player hero1 = new Player() { Health = 10, Armor = 0 };
            Player badguy1 = new Player() { Name = "Thug", Health = 10, Armor = 2, Item1 = glock };

            // Get Hero's Name
            Console.WriteLine("What is your player's name?");
            hero1.Name = Console.ReadLine();

            // Explore and get items
            Events.PickUpItem(hero1, glock);
            Events.PickUpItem(hero1, mouser);
            Events.PickUpItem(hero1, bazuka);

            // Do Battle
            while (hero1.Health > 0 || badguy1.Health > 0)
            {
                Events.Attack(hero1, badguy1);

                if (hero1.Health <= 0)
                {
                    Console.WriteLine("Oh noooos.  You died!");
                    break;
                }
                else if (badguy1.Health <= 0)
                {
                    Console.WriteLine("Wohoo!  You got'm!");
                    break;
                }
            }
            

            Console.ReadLine();
        }
    }
}
