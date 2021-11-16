using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Actions
    {
        public static void Shoot(Gun gun, int shots, Player badguy)
        {
            gun.AmmoLoaded -= shots;

            // Calculate Hit Chance (if random > badguy.armor then success)
            Random rnd = new Random();
            int hitChance = rnd.Next(1, 10);
            if (hitChance > badguy.Armor)
            {
                badguy.Health -= gun.damage;
                Console.WriteLine("You HIT!\nYou have " + gun.AmmoLoaded + " shots left.\nThe " + badguy.Name + " has " + Math.Max(0, badguy.Health) + " health left.");
            } else
            {
                Console.WriteLine("You Missed!\nYou have " + gun.AmmoLoaded + " shots left.\nThe " + badguy.Name + " has " + Math.Max(0, badguy.Health) + " health left.");
            }
        }

        public static void Reload(Gun gun)
        {
            gun.AmmoLoaded = gun.AmmoMax;
        }
        
        public static void PickupItem(Player player, Gun item)
        {
            if (player.Item1 == null)
            {
                player.Item1 = item;
                Console.WriteLine("You equip the " + item.GunName + " in slot 1.");
            }
            else if (player.Item2 == null)
            {
                player.Item2 = item;
                Console.WriteLine("You equip the " + item.GunName + " in slot 2.");
            }
            else 
            { 
                Console.WriteLine("You have too many items.  Drop an item?\nDrop:\n[1] " + player.Item1.GunName + "\n[2] " + player.Item2.GunName + "\n[3] Nothing");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("You drop the " + player.Item1.GunName + " and equip the " + item.GunName + " in slot 1.");
                        player.Item1 = item; break;
                    case "2":
                        Console.WriteLine("You drop the " + player.Item2.GunName + " and equip the " + item.GunName + " in slot 2.");
                        player.Item2 = item; break;
                    default:
                        break;
                }
            }
        }
    }
}
